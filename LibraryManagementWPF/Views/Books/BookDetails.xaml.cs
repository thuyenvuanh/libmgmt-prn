using BusinessObject.Models;
using Repository;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF.Views.Books;

public partial class BookDetails : FluentWindow
{
    public Book SelectedBook { get; set; }
    public Account SelectedAccount { get; set; }

    private readonly IBorrowItemRepository borrowItemRepository;
    private readonly IAuthorRepository authorRepository;

    public BookDetails()
    {
        borrowItemRepository = new BorrowItemRepository();
        authorRepository = new AuthorRepository();
        InitializeComponent();
    }

    public BookDetails(Book book, Account account) : this()
    {
        SelectedAccount = account;
        SelectedBook = book;
        formGrid.DataContext = SelectedBook;
        Author author = authorRepository.GetById(book.Author)!;
        pnlAuthorDetails.DataContext = author;
    }

    private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var confirmMsg = new Wpf.Ui.Controls.MessageBox()
        {
            Title = "Confirmation",
            Content = $"You want to borrow \"{SelectedBook.Name}\"?",
            PrimaryButtonText = "Yes",
            CloseButtonText = "No",
        };
        var result = confirmMsg.ShowDialogAsync().Result;
        if (result == MessageBoxResult.Primary)
        {
            BorrowItem? borrowItem = borrowItemRepository.GetBorrowItemByAccountAndBook(SelectedAccount.Id, SelectedBook.Id);
            if (borrowItem != null)
            {
                ShowMessageBox(title: "Error", content: "You already borrowed this book");
            }
            else
            {
                borrowItem = new()
                {
                    Book = SelectedBook.Id,
                    Borrower = SelectedAccount.Id,
                    BorrowedDate = DateTime.Now,
                    ReturnedDate = null,
                    Period = 2,
                };
                borrowItemRepository.BorrowBook(borrowItem);
                ShowMessageBox(title: "Successfully", content: $"Borrow {SelectedBook.Name} successfully", showPrimary: true);
            }
        }
    }

    private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        this.Close();
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
}
