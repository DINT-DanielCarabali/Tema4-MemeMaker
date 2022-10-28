using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MemeMaker
{
    class BordesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return new Thickness(2);
            else
                return new Thickness(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}