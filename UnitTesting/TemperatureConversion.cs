using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class TemperatureConversion
    {

        public Double FahrenheitToCelcius(Double Temperature)
        {
           Double celcius= (Temperature - 32) * 5 / 9;
            return celcius;
        }
        public Double CelciusToFahrenheit(Double Temperature)
        {
            Double Fahrenheit = (Temperature * 9/5) +32;
            return Fahrenheit;
        }
        public void Print(double temp)
        {
           Console.WriteLine("The Converted temperature is :",temp);
        }
        public void Conversion()
        {
            Console.WriteLine("Enter 1 To convert Fahrenhiet to Celcius\n" + "Enter 1 To convert  Celcius to Fahrenhiet\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Temperature");
            double tt=Convert.ToDouble(Console.ReadLine());
            double temp;
            switch (n)
            {
                case 1:
                        temp = FahrenheitToCelcius(tt);
                    Print(temp);
                    break;
                case 2:
                         temp = CelciusToFahrenheit(tt);
                    Print(temp);
                    break;
            }

        }
    }
}
