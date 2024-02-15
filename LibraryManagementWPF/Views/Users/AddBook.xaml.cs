using BusinessObject.Models;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF.Views.Users
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : FluentWindow
    {
        private Book NewBook { get; set; } = new Book();

        public AddBook()
        {
            InitializeComponent();
        }

        public AddBook(Book book): this()
        {

        }

        private void pckerPublishedDate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Console.WriteLine("Selected date changed");
        }

        private void pckerPublishedDate_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
