using BusinessObject;
using BusinessObject.Models;
using LibraryManagementWPF.Views.Pages;
using Repository;
using System.Windows;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF.Views.Users;

/// <summary>
/// Interaction logic for AddUser.xaml
/// </summary>
public partial class AddUser : FluentWindow
{
    private Account? Account { get; set; } = new()
    {
        Email = "",
        Password = "",
        Role = -1
    };

    private readonly IAccountRepository accountRepository;

    public AddUser()
    {
        accountRepository = new AccountRepository();
        InitializeComponent();
        LoadComboBox();
        formGrid.DataContext = Account;
    }

    public AddUser(Account? account) : this()
    {
        Account = account;
        cbxRole.SelectedIndex = Account?.Role - 1 ?? -1;
        formGrid.DataContext = Account;
    }

    private void LoadComboBox()
    {
        cbxRole.ItemsSource = Enum.GetValues(typeof(ERole));
        cbxRole.SelectionChanged += CbxRole_SelectionChanged;
    }

    private void CbxRole_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        Account!.Role = (int) cbxRole.SelectedValue;
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
        if (!ValidateForm()) return;
        accountRepository.SaveAccount(Account!);
        this.Close();
    }

    private bool ValidateForm()
    {
        if (string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxPassword.Text) || cbxRole.SelectedItem == null)
        {
            //Show Error
            return false;
        }
        if (cbxRole.SelectedItem == null) { return false; }

        // if email is existed
        var account = accountRepository.GetByEmail(tbxEmail.Text);
        if (account != null) { return false; }

        return true;
    }

    private void tbxPassword_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (Account != null)
        {
            Account.Password = ((PasswordBox)sender).Password;
        }
    }

    private void cbxRole_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        Account!.Role = ((ComboBox)sender).SelectedIndex + 1;
    }
}
