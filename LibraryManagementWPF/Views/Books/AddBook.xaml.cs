using BusinessObject.Models;
using Repository;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF.Views.Books
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : FluentWindow
    {
        private readonly BookRepository bookRepository;

        private readonly AuthorRepository authorRepository;

        private Author originalAuthor = new();

        private Book SelectedBook { get; set; } = new Book() 
        {
            Id = 0,
            Name = "",
            Author = 0,
            Isbn = "",
            PublishedDate = DateTime.Now,
        };

        private Author SelectedAuthor { get; set; } = new() { Birthday = DateTime.Now };

        public AddBook()
        {
            bookRepository = new();
            authorRepository = new AuthorRepository();
            InitializeComponent();
            formGrid.DataContext = SelectedBook;
            sbxAuthorSearch.OriginalItemsSource = authorRepository.GetAll().ConvertAll(a => string.Format("{0}. {1}", a.Id, a.Name));
            tglNewAuthor.IsChecked = false;
            pnlNewAuthor.IsEnabled = false;
            pnlNewAuthor.DataContext = SelectedAuthor;
        }

        public AddBook(Book book): this()
        {
            SelectedBook = book;
            SelectedAuthor = authorRepository.GetById(book.Author) ?? new();
            pnlNewAuthor.DataContext = SelectedAuthor;
            formGrid.DataContext = SelectedBook;
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            SelectedBook.Author = SelectedAuthor.Id;
            if (SelectedBook.Author == 0)
            {
                SelectedBook.AuthorNavigation = SelectedAuthor;
            }
            bookRepository.Save(SelectedBook);
            Close();
        }

        private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }

        private bool ValidateForm()
        {
            // validate book
            if (string.IsNullOrEmpty(SelectedBook.Name) || string.IsNullOrEmpty(SelectedBook.Isbn) || SelectedBook.PublishedDate > DateTime.Now)
            {
                return false;
            }
            // validate author
            if (string.IsNullOrEmpty(SelectedAuthor.Name) || SelectedAuthor.Birthday > DateTime.Now)
            {
                return false;
            }

            return true;
        }

        private void tglNewAuthor_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedAuthor.Id = 0;
            SelectedAuthor.Name = string.Empty;
            SelectedAuthor.Birthday = DateTime.Today;
            pnlNewAuthor.DataContext = SelectedAuthor;
            pnlSelectAuthor.IsEnabled = false;
            pnlNewAuthor.IsEnabled = true;
        }

        private void tglNewAuthor_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            pnlSelectAuthor.IsEnabled = true;
            pnlNewAuthor.IsEnabled = false;
            Author author = authorRepository.GetById(SelectedBook.Author) ?? new() { Birthday = DateTime.Now};
            SelectedAuthor.Id = author.Id;
            SelectedAuthor.Name = author.Name;
            SelectedAuthor.Birthday = author.Birthday;
        }

        private void sbxAuthorSearch_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            int id = int.Parse((args.SelectedItem as string)!.Split(".")[0]);
            var author = authorRepository.GetById(id);
            if (author == null)
            {
                return;
            }
            SelectedAuthor.Name = author.Name;
            SelectedAuthor.Id = author.Id;
            SelectedAuthor.Birthday = author.Birthday;
            tbxAuthorName.Text = SelectedAuthor.Name;
            pckerBirthday.SelectedDate = SelectedAuthor.Birthday;
        }
    }
}
