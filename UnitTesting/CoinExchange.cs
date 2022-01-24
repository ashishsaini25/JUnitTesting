using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
     public  class CoinExchange
    {
        Dictionary<int, int> Currencies = new Dictionary<int, int>()
        {
            {1000,0 },
            {500,0},
            {100,0 },
            {50,0 },
            {20,0 },
            {10,0 },
            {5,0 },
            {2,0 },
            {1,0 },
        };
        public int Notes(int amount)
        {
            if (amount == 0) return 0;

            if (amount > 1000)
            {
                
                Currencies[1000]=amount/1000;
                return (amount/1000)+Notes(amount % 1000);
            }
            if (amount > 500)
            {
                Currencies[500]=amount/500;
                return (amount/500)+Notes(amount % 500);
            }
            if (amount > 100)
            {
                Currencies[100]=amount/100;
                return (amount/100)+Notes(amount%100);
            }
            if (amount > 50)
            {
                Currencies[50]=amount/50;
                return amount/50+Notes(amount % 50);
            }
            if (amount > 10)
            {
                Currencies[10]=amount/10;
                return (amount/10)+Notes(amount %10);
            }
            if (amount > 5)
            {
                Currencies[5] = amount / 5;
                return (amount/5)+Notes(amount %5);
            }
            if (amount > 2)
            {
                Currencies[2]=amount/2;
                return (amount/2)+Notes(amount % 2);
            }
            else
            {
                
                    Currencies[1]++;
                    return 1+Notes(amount - 1);
                
            }

        }
        public void Change()
        {
            Console.WriteLine("Enter Your Amount\n");
            int amount =Convert.ToInt32(Console.ReadLine());
            int number = Notes(amount);
            Console.WriteLine("The Minimum Notes required are {0}", number);
            Console.WriteLine("The Respective Domination required will be\n");
            Console.WriteLine("Value        NumberOfNotes\n");
            foreach (KeyValuePair<int, int> i in Currencies)
            {
                if(i.Value>0)
                Console.WriteLine(i.Key+"       "+ i.Value);
            }
    
        }
    }
}
