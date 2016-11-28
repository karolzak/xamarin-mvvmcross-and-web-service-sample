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
    public class IntToStringConverter
        : IMvxValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return value.ToString();
            }
            catch { return "0"; }
      
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return System.Convert.ToInt32(value);

            }
            catch
            {
                return 0;

            }
        }
    }
}
