using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Conversion
    {
        private int ConversionValue;
        private double ConvertedValue;

        public Conversion()
        {
            this.ConversionValue = 1;
        }

        public Conversion(int ConversionValue)
        {
            this.ConversionValue = ConversionValue;
        }

        public double ConvertCelciusToFahrenheit()
        {
           
            ConvertedValue = ((ConversionValue * 9) / 5) + 32;
            return ConvertedValue;
        }

        public double ConvertCelciusToKelvin()
        {
         
            ConvertedValue = (ConversionValue + 273.15);
            return ConvertedValue;
        }

       
        public double ConvertKelvinToFahrenheit()
        {
            ConvertedValue = (((ConversionValue - 273.15)*1.8) + 32);
            return ConvertedValue;
        }

        public double ConvertKelvinToCelcius()
        {
            
            ConvertedValue = (ConversionValue - 273.15);
            return ConvertedValue;
        }

       
        public double ConvertFahrenheitToKelvin()
        {

            ConvertedValue = (ConversionValue - 32) / 1.8 + 273.15;
            return ConvertedValue;
        }

        public double ConvertFahrenheitToCelcius()
        {
           
            ConvertedValue = ((ConversionValue-32)*(5/9));
            return ConvertedValue;
        }

    }
}
