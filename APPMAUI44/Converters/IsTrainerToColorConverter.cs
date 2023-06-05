using System;
using System.Globalization;
using APPMAUI44.Core.ViewModel;

namespace APPMAUI44.Converters
{
	public class IsTrainerToColorConverter:IValueConverter
	{
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not null && value is bool)
            {
                return ((bool)value) ? Colors.Red : Colors.Black;
            }
            return Colors.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

