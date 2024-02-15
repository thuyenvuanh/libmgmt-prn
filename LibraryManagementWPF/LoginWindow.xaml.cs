using BusinessObject.Models;
using Repository;
using System.Windows;
using System.Windows.Input;
using Wpf.Ui.Appearance;

namespace LibraryManagementWPF
{
    public partial class LoginWindow : Wpf.Ui.Controls.FluentWindow
    {
        private readonly IAccountRepository accountRepository;

        public LoginWindow()
        {
            accountRepository = new AccountRepository();
            InitializeComponent();
            errorBar.IsOpen = false;
            titleBar.CloseClicked += GlobalEventHandlers.closeApplication;
            Loaded += (sender, args) => SystemThemeWatcher.Watch(this, Wpf.Ui.Controls.WindowBackdropType.Acrylic, true);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            string userId = tbxUserId.Text;
            if (string.IsNullOrEmpty(userId))
            {
                showError("UserId or Email is required");
                return;
            }
            string pwd = tbxPwd.Password;
            if (string.IsNullOrEmpty(pwd))
            {
                showError("Password is required");
                return;
            }
            bool result = accountRepository.Login(userId, pwd);
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
            if (result)
            {
                Account account;
                bool value = int.TryParse(tbxUserId.Text, out int uid);
                if (value)
                {
                    account = accountRepository.GetByID(uid)!;
                }
                else
                {
                    account = accountRepository.GetByEmail(tbxUserId.Text)!;
                }
                MainWindow main = new(account)
                {
                    Owner = this
                };
                Hide();
                tbxPwd.Clear();
                main.Show();
            }
            else
            {
                showError("Password incorrect or userId/Email not found");
            }
        }

        private void showError(string message)
        {
            errorBar.Message = message;
            errorBar.IsOpen = true;
        }
    }
}
