using BusinessObject.Models;
using LibraryManagementWPF.Views.Books;
using Repository;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for Discovery.xaml
    /// </summary>
    public partial class Discovery : Page, PageProps
    {
        private static string name = "Discovery";

        private readonly IBookRepository bookRepository;

        private readonly IBorrowItemRepository borrowItemRepository;

        public Discovery()
        {
            bookRepository = new BookRepository();
            borrowItemRepository = new BorrowItemRepository();
            InitializeComponent();
            LoadData();
            pnlBookSelected.IsEnabled = false;
        }

        private void LoadData()
        {
            var books = bookRepository.GetAll();
            dgvBook.ItemsSource = books;
        }

        public string GetName() => name;

        private void dgvBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pnlBookSelected.IsEnabled = true;
        }

        private void btnBorrow_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Book selectedBook = (Book)dgvBook.SelectedItem;
            if (selectedBook != null)
            {
                var confirmMsg = new Wpf.Ui.Controls.MessageBox()
                {
                    Title = "Confirmation",
                    Content = $"You want to borrow \"{selectedBook.Name}\"?",
                    PrimaryButtonText = "Yes",
                    CloseButtonText = "No",
                };
                var result = confirmMsg.ShowDialogAsync().Result;
                if (result == Wpf.Ui.Controls.MessageBoxResult.Primary)
                {
                    var currentUser = ((MainWindow)Window.GetWindow(this)).LoggedInUser;
                    BorrowItem? borrowItem = borrowItemRepository.GetBorrowItemByAccountAndBook(currentUser.Id, selectedBook.Id);
                    if (borrowItem != null)
                    {
                        ShowMessageBox(title: "Error", content: "You already borrowed this book");
                    }
                    else
                    {
                        borrowItem = new()
                        {
                            Book = selectedBook.Id,
                            Borrower = currentUser.Id,
                            BorrowedDate = DateTime.Now,
                            ReturnedDate = null,
                            Period = 2,
                        };
                        borrowItemRepository.BorrowBook(borrowItem);
                        ShowMessageBox(title: "Successfully", content: $"Borrow {selectedBook.Name} successfully", showPrimary: true);
                    }
                }
            }
        }

        private void btnDetails_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BookDetails bookDetails = new BookDetails(account: ((MainWindow)Window.GetWindow(this)).LoggedInUser, book: (Book)dgvBook.SelectedItem);
            bookDetails.Show();

        }

        private Wpf.Ui.Controls.MessageBoxResult ShowMessageBox(string title, string content, bool showPrimary = false)
        {
            var msgBox = new Wpf.Ui.Controls.MessageBox() 
            {
                Title = title,
                Content = content,
                IsPrimaryButtonEnabled = showPrimary,
                PrimaryButtonText = "OK"
            };
            return msgBox.ShowDialogAsync().Result;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
            ResetSelectedData();
            tbxSearchBook.Clear();
        }

        private void ResetSelectedData()
        {
            dgvBook.SelectedIndex = -1;
            dgvBook.SelectedItem = null;
            dgvBook.SelectedItems.Clear();
            dgvBook.SelectedValue = null;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = tbxSearchBook.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                var books = bookRepository.SearchByName(keyword);
                dgvBook.ItemsSource = books;
                ResetSelectedData();
            }
        }
    }
}
