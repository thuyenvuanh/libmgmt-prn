using System.Globalization;
using System.Windows.Data;

namespace LibraryManagementWPF.Converters;

public class ReturnedDateConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
        {
            return "Not Yet";
        }
        return (DateTime?)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
