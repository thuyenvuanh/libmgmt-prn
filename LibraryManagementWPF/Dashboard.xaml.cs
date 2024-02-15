using BusinessObject.Models;
using LibraryManagementWPF.Views.Pages;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF
{
    public partial class MainWindow : FluentWindow
    {
        private readonly Account loggedInUser = new();

        public MainWindow()
        {
            InitializeComponent();
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {

        }

        public MainWindow(Account account) : this()
        {
            loggedInUser = account;
            loggedInUser = new Account();
            titleBar.CloseClicked += GlobalEventHandlers.closeApplication;
            DataContext = this;
            Loaded += (_, _) => RootNavigation.Navigate(typeof(UserManagement));
        }

        private void RootNavigation_Navigated(NavigationView sender, NavigatedEventArgs args)
        {
            RootNavigation.PaneTitle = ((PageProps)args.Page).GetName();
        }

        private void logOutBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.Application.Current.Windows[0].Show();
            for (int i = 1; i < System.Windows.Application.Current.Windows.Count; i++)
            {
                System.Windows.Application.Current.Windows[i].Close();
            }
            Close();
        }
    }
}