using BusinessObject.Models;
using LibraryManagementWPF.Views.Books;
using LibraryManagementWPF.Views.Users;
using Repository;
using System.Windows;
using System.Windows.Controls;

namespace LibraryManagementWPF.Views.Pages;

public partial class BookManagement : Page, PageProps
{
    private static string name = "Book Management";

    private readonly BookRepository bookRepository;

    public string GetName() => name;

    public BookManagement()
    {
        bookRepository = new();
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
        btnEdit.IsEnabled = isEnable;
    }

    private void LoadBooks()
    {
        List<Book> books = bookRepository.GetAll();
        dgvBook.ItemsSource = books;
    }

    private void btnRefresh_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        LoadBooks();
    }

    private void btnEdit_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var selectedBook = dgvBook.SelectedItem as Book;
        if (selectedBook != null)
        {
            AddBook addBook = new AddBook(selectedBook)
            {
                Owner = Window.GetWindow(this)
            };
            addBook.Show();
            addBook.Closed += (_, _) => LoadBooks();
        }
    }

    private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        AddBook addBook = new AddBook()
        {
            Owner = Window.GetWindow(this)
        };
        addBook.Show();
        addBook.Closed += (_, _) => LoadBooks();
    }

    private void btnSearch_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var books = bookRepository.SearchByName(tbxSearch.Text);
        dgvBook.ItemsSource = books;
        dgvBook.SelectedIndex = -1;
        dgvBook.SelectedItem = null;
        ToggleEditAndDelBtns(false);
    }

    private void dgvBook_SelectionChanged(object sender, SelectionChangedEventArgs e) => ToggleEditAndDelBtns(dgvBook.SelectedItem != null);
}
