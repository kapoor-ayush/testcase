using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.StartProcess();
            Console.ReadKey();
        }

        public void StartProcess()
        {
            string cValue;
            int convertValue;
            do {
                Console.WriteLine("Enter the value to be converted: ");
                cValue = Console.ReadLine();
            }while(!int.TryParse(cValue, out convertValue) || (convertValue < 1));

                Console.WriteLine("What kind of the operation you want to perform?");
                Console.WriteLine("Press 1 for Celcius to Fahrenheit");
                Console.WriteLine("Press 2 for Celcius to Kelvin");
                Console.WriteLine("Press 3 for Kelvin to Fahrenheit");
                Console.WriteLine("Press 4 for Kelvin to Celcius");
                Console.WriteLine("Press 5 for Fahrenheit to Kelvin");
                Console.WriteLine("Press 6 for Fahrenheit to Celcius");
                Console.WriteLine("Press 7 for Exit");

                int userAction;
                string uChoice = string.Empty;
                do
                {
                    Console.WriteLine("Select any options from 1 to 7::");
                    uChoice = Console.ReadLine();

                } while (!int.TryParse(uChoice, out userAction) || (userAction < 1) || (userAction > 7));

            Conversion conversion = new Conversion(convertValue);
            double result;
            switch (userAction)
            {
                case 1:
                       
                        result = conversion.ConvertCelciusToFahrenheit();
                        Console.WriteLine(result);
                        break;
                    
                case 2:
                    result = conversion.ConvertCelciusToKelvin();
                    Console.WriteLine(result);
                    break;
               
                case 3:
                    result = conversion.ConvertKelvinToFahrenheit();
                    Console.WriteLine(result);
                    break;
                case 4:
                    result = conversion.ConvertKelvinToCelcius();
                    Console.WriteLine(result);
                    break;

                case 5:
                    result = conversion.ConvertFahrenheitToKelvin();
                    Console.WriteLine(result);
                    break;
                case 6:
                    result = conversion.ConvertFahrenheitToCelcius();
                    Console.WriteLine(result);
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Your choicee is wrong");
                    break;
            }

            }
        }
}
