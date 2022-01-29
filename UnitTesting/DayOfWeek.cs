using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    static class  DayOfWeek
    {
        public static void Input()
        {
            Console.WriteLine("Enter the Month Day Year respectively");
            int month, day, year;
            month =Convert.ToInt32( Console.ReadLine());
            day = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
             int year1 = year - (14 - month) / 12;
            int x = year1 + year1 / 4 - year1 / 100 + year1 / 400;
            int month1 = month + 12 * ((14 - month) / 12) - 2;
            int day1 = (day+x+31*month1/12)%7;
            switch (day1)
            {
                case 0:
                    Console.WriteLine("The Day Was Sunday\n");
                    break;
                case 1:
                    Console.WriteLine("The Day Was Monday\n");
                    break;
                case 2:
                    Console.WriteLine("The Day Was Tuesday\n");
                    break;
                case 3:
                    Console.WriteLine("The Day Was Wednesday\n");
                    break;
                case 4:
                    Console.WriteLine("The Day Was Thursday\n");
                    break;
                case 5:
                    Console.WriteLine("The Day Was Friday\n");
                    break;
                default:
                    Console.WriteLine("The Day Was Saturday\n");
                    break;

            }
        }
    }
}
