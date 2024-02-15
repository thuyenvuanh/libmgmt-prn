using BusinessObject;
using BusinessObject.Models;
using LibraryManagementWPF.Views.Users;
using Repository;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for UserManagement.xaml
    /// </summary>
    public partial class UserManagement : Page, PageProps
    {
        private const string Name = "User Management";

        public string GetName() => Name;

        private readonly AccountRepository accountRepository;

        public UserManagement()
        {
            accountRepository = new AccountRepository();
            InitializeComponent();
            LoadAccounts();
            ToggleEditAndDelBtns(false);
        }

        private void ToggleEditAndDelBtns(bool isEnable)
        {
            btnDel.IsEnabled = isEnable;
            btnEdit.IsEnabled = isEnable;
        }

        private void LoadAccounts()
        {
            List<Account> accounts = accountRepository.GetAll();
            dgUserList.ItemsSource = accounts ?? new List<Account>();
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddUser addUser = new()
            {
                Owner = Window.GetWindow(this)
            };
            addUser.Closed += (_,_) => LoadAccounts();
            addUser.Show();
        }

        private void btnEdit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Account? account = dgUserList.SelectedItem as Account;
            if (account == null) return;
            AddUser editUser = new AddUser(account);
            editUser.Show();
        }

        private void dgUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgUserList.SelectedIndex >= 0)
            {
                ToggleEditAndDelBtns(true);
            }
        }

        private void btnRefresh_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            LoadAccounts();
        }

        private async void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = (Account)dgUserList.SelectedItem!;
            string accountDetails = 
                $@"    ID: {selectedAccount.Id}
    Email: {selectedAccount.Email}
    Role: {(ERole) selectedAccount.Role}";

            var result = new Wpf.Ui.Controls.MessageBox() 
            {
                Title="Delete Alert",
                Content="Do you want to delete this account \n" + accountDetails,
                PrimaryButtonAppearance=ControlAppearance.Danger,
                CloseButtonText="Cancel",
                PrimaryButtonText="Delete it",
            }.ShowDialogAsync().Result;
            if (result == Wpf.Ui.Controls.MessageBoxResult.Primary)
            {
                accountRepository.Delete(selectedAccount);
            }
            LoadAccounts();
        }
    }
}
