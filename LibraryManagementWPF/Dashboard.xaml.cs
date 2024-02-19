using BusinessObject.Models;
using LibraryManagementWPF.Views.Pages;
using System.Linq;
using Wpf.Ui.Controls;

namespace LibraryManagementWPF
{
    public partial class MainWindow : FluentWindow
    {
        private readonly Account loggedInUser = new();

        private readonly List<Type> initialPage = new List<Type>() { typeof(UserManagement), typeof(BookManagement), typeof(Discovery) };

        private readonly List<List<Type>> permissionsByRole = new List<List<Type>>
        {
            new List<Type>(){ typeof(UserManagement) },
            new List<Type>(){ typeof(BookManagement) },
            new List<Type>(){ typeof(Discovery), typeof(Bookshelf) },
        };

        public Account LoggedInUser { get { return loggedInUser; } }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadUserDetails()
        {
            userInfo.Content = loggedInUser.Email;
            DataContext = this;
            Loaded += (_, _) => RootNavigation.Navigate(initialPage[loggedInUser.Role - 1]);
        }

        private void LoadMenuItems()
        {
            var menuItems = RootNavigation.MenuItems;
            foreach (NavigationViewItem item in menuItems)
            {
                int role = loggedInUser.Role;
                if (permissionsByRole.ElementAt(role - 1).Contains(item.TargetPageType!))
                {
                    item.Visibility = System.Windows.Visibility.Visible;
                } 
                else
                {
                    item.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }

        public MainWindow(Account account) : this()
        {
            loggedInUser = account;
            titleBar.CloseClicked += GlobalEventHandlers.closeApplication;
            LoadUserDetails();
            Loaded += (_,_) => LoadMenuItems();
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