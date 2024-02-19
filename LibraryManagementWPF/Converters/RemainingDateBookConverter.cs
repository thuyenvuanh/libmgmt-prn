using BusinessObject.Models;
using System.Globalization;
using System.Windows.Data;

namespace LibraryManagementWPF.Converters;

public class RemainingDateBookConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var borrowItem = (BorrowItem)value;
        var returnedDate = ((DateTime)borrowItem.BorrowedDate).AddDays(borrowItem.Period * 7);
        if (returnedDate < DateTime.Now)
        {
            return 0;
        }
        return returnedDate.Subtract(DateTime.Now).Days;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
