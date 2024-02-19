using BusinessObject.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Repository;
using System.Windows;
using System.Windows.Controls;

namespace LibraryManagementWPF.Views.Pages;

public partial class Bookshelf : Page, PageProps
{
    private static string name = "Bookshelf";


    private readonly IBorrowItemRepository borrowItemRepository;

    public Bookshelf()
    {
        borrowItemRepository = new BorrowItemRepository();
        InitializeComponent();
    }

    private void LoadData(bool isChecked = false)
    {
        var account = ((MainWindow)Window.GetWindow(this))?.LoggedInUser;
        var borrowedItems = borrowItemRepository.GetBorrowItemsByAccount(account, isChecked);
        dgvBorrowedBook.ItemsSource = borrowedItems;
        ResetDataGrid();
    }

    public string GetName() => name;

    private void chboxReturnBooks_Checked(object sender, RoutedEventArgs e)
    {
        LoadData(true);
    }

    private void chboxReturnBooks_Unchecked(object sender, RoutedEventArgs e)
    {
        LoadData();
    }

    private void ResetDataGrid()
    {
        dgvBorrowedBook.SelectedItem = null;
        dgvBorrowedBook.SelectedIndex = -1;
        dgvBorrowedBook.SelectedValue = null;
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        LoadData();
        ToggleButtons(false);
    }

    private void ToggleButtons(bool isEnabled)
    {
        btnReturn.IsEnabled = isEnabled;
    }

    private void btnRefresh_Click(object sender, RoutedEventArgs e)
    {
        LoadData();
        ToggleButtons(false);
    }

    private void dgvBorrowedBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ToggleButtons(dgvBorrowedBook.SelectedItem != null);
    }

    private void btnReturn_Click(object sender, RoutedEventArgs e)
    {
        BorrowItem? borrowItem = dgvBorrowedBook.SelectedItem as BorrowItem;
        if (borrowItem == null) { btnReturn.IsEnabled = false; return; }
        Wpf.Ui.Controls.MessageBox msgConfirm = new Wpf.Ui.Controls.MessageBox()
        {
            Title = "Confirmation",
            Content = $"You want to return \"{borrowItem.BookNavigation.Name}\"?",
            PrimaryButtonText = "OK",
            CloseButtonText = "Cancel",
        };
        if (msgConfirm.ShowDialogAsync().Result == Wpf.Ui.Controls.MessageBoxResult.Primary)
        {
            borrowItem.ReturnedDate = DateTime.Now;
            borrowItemRepository.ReturnBook(borrowItem);
        }
        LoadData();
    }
}
