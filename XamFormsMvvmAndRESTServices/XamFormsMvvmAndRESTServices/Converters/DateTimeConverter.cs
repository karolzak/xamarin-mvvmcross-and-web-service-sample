using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace XamFormsMvvmAndRESTServices.Converters
{
    //SHOW: Converters 1 Mvx Value Converters
    public class DateTimeConverter : IMvxValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = ((DateTimeOffset)value).ToString("dd/MM/yyyy");
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
