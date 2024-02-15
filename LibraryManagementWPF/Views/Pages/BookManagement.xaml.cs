using BusinessObject.Models;
using LibraryManagementWPF.Views.Users;
using Repository;
using System.Windows;
using System.Windows.Controls;

namespace LibraryManagementWPF.Views.Pages;

public partial class BookManagement : Page, PageProps
{
    private static string name = "Book Management";

    private readonly BookRepository repository;

    public string GetName() => name;

    public BookManagement()
    {
        repository = new();
        InitializeComponent();
        LoadBooks();
        LoadViews();
        ToggleEditAndDelBtns(false);
    }

    private void LoadViews()
    {
        dgvBook.SelectedIndex = -1;
        dgvBook.SelectedItem = null;
    }

    private void ToggleEditAndDelBtns(bool isEnable)
    {
        btnDel.IsEnabled = isEnable;
        btnEdit.IsEnabled = isEnable;
    }

    private void LoadBooks()
    {
        List<Book> books = repository.GetAll();
        dgvBook.ItemsSource = books;
    }

    private void btnRefresh_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

    private void btnDel_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

    private void btnEdit_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

    private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        AddBook addBook = new AddBook()
        {
            Owner = Window.GetWindow(this)
        };
        addBook.Show();
    }

    private void btnSearch_Click(object sender, System.Windows.RoutedEventArgs e)
    {

    }

    private void dgvBook_SelectionChanged(object sender, SelectionChangedEventArgs e) => ToggleEditAndDelBtns(dgvBook.SelectedItem != null);
}
