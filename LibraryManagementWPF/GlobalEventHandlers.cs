using System.Windows;

namespace LibraryManagementWPF;

class GlobalEventHandlers
{
    public static void closeApplication(Wpf.Ui.Controls.TitleBar sender, RoutedEventArgs args)
    {
        foreach (Window item in System.Windows.Application.Current.Windows)
        {
            item.Close();
        }
    }
}
