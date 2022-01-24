using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1 To Coin Change Problem\n");
                int n=Convert.ToInt32(Console.ReadLine());
                switch(n){
                    case 1:
                        CoinExchange coinExchange = new CoinExchange();
                        coinExchange.Change();
                        break;
                }
            }
        }
    }
}
