using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment02;

namespace Assignment2Test
{
    public class ConversionTest
    {
        [Test]
        public void CelciusToFahrenheitPositive()
        {
            var conversion = new Conversion(10);

            double result = conversion.ConvertCelciusToFahrenheit();
            double expectedResult = 50;

            Assert.AreEqual(expectedResult,result);

        }

        [Test]
        public void CelciusToFahrenheitZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertCelciusToFahrenheit();
            double expectedResult = 32;

            Assert.AreEqual(expectedResult,result);
        }

        [Test]
        public void CelciusToFahrenheitDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertCelciusToFahrenheit();
            
            double expectedResult = 33;

            Assert.AreEqual(expectedResult,result);
        }

        [Test]
        public void CelciusToKelvinPositive()
        {
            var conversion = new Conversion(12);

            double result = conversion.ConvertCelciusToKelvin();

            double expectedResult = 285;

            Assert.AreEqual(expectedResult,Math.Round(result));
        }

        [Test]
        public void CelciusToKelvinZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertCelciusToKelvin();

            double expectedResult = 273.15;

            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void CelciusToKelvinDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertCelciusToKelvin();

            double expectedResult = 274.15;

            Assert.AreEqual(expectedResult, result);
        }
      
        [Test]
        public void KelvinToFahrenhitPositive()
        {
            var conversion = new Conversion(25);

            double result = conversion.ConvertKelvinToFahrenheit();

            double expectedResult = -415;

            Assert.AreEqual(expectedResult,Math.Round( result));
        }

        [Test]
        public void KelvinToFahrenhitZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertKelvinToFahrenheit();

            double expectedResult = -460;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void KelvinToFahrenhitDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertKelvinToFahrenheit();

            double expectedResult = -458;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void KelvinToCelciusPositive()
        {
            var conversion = new Conversion(98);

            double result = conversion.ConvertKelvinToCelcius();

            double expectedResult = -175;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void KelvinToCelciusZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertKelvinToCelcius();

            double expectedResult = -273;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }
        [Test]
        public void KelvinToCelciusDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertKelvinToCelcius();

            double expectedResult = -272;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void FehrenhitToKelvinPositive()
        {
            var conversion = new Conversion(99);

            double result = conversion.ConvertFahrenheitToKelvin();

            double expectedResult = 310;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void FehrenhitToKelvinZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertFahrenheitToKelvin();

            double expectedResult = 255;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void FehrenhitToKelvinDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertFahrenheitToKelvin();

            double expectedResult = 256;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void FahrenhitToCelciusPositive()
        {
            var conversion = new Conversion(65);
            double result = conversion.ConvertFahrenheitToCelcius();

            double expectedResult = 0;

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void FahrenhitToCelciusZero()
        {
            var conversion = new Conversion(0);
            double result = conversion.ConvertFahrenheitToCelcius();

            double expectedResult = 0;

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void FahrenhitToCelciusDefault()
        {
            var conversion = new Conversion();
            double result = conversion.ConvertFahrenheitToCelcius();

            double expectedResult = 0;

            Assert.AreEqual(expectedResult, result);

        }
    }
}
