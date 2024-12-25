using System;
using System.Globalization;
using System.Windows.Data;
using Filtration.ObjectModel.Enums;

namespace Filtration.Converters
{
    public class IntToGemQualityTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (GemQualityType) (int) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int) (GemQualityType) value;
        }
    }
}
