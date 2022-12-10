using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicApp.Common.ValueConverters
{
    public class AppointmentRowTimeValueConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                DateTime val = (DateTime)values[0];
                int intDuration= (int) values[1];
                double duration = intDuration;

                val.AddMinutes(duration);

                if (val < DateTime.Now)
                {
                    return true;
                }
                return false;
            }
            catch (InvalidCastException)
            {
                return false;
            }
            
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
