using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class DecimalToBinary
    {
        public void Print()
        {
            Console.WriteLine("Enter the number\n");
            int n=Convert.ToInt32(Console.ReadLine());
            var binary= new StringBuilder();
            while (n > 0)
            {
               // Console.WriteLine("**");
                int curr = n % 2;
                binary.Append(curr);
                n /= 2;
            }
            Console.WriteLine(binary.Length);
            string temp = binary.ToString();
            temp.Reverse();
            Console.WriteLine(temp);

        }
    }
}
