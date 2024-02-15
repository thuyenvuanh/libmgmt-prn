using System.Windows.Controls;

namespace LibraryManagementWPF.Views.Pages;

public partial class Borrow : Page, PageProps
{
    private static string name = "Borrow/Return";

    public Borrow()
    {
        InitializeComponent();
    }

    public string GetName() => name;
}
