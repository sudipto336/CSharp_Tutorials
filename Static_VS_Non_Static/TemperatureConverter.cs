using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_VS_Non_Static
{
    internal static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string celciusTempaeraure)
        {
            return (((9 / 5) * (Double.Parse(celciusTempaeraure))) + 32);
        }

        public static double FahrenheitToCelsius(string fahrenheitTempaeraure)
        {
            return (((9 / 5) * (Double.Parse(fahrenheitTempaeraure))) + 32);
        }
    }
}
