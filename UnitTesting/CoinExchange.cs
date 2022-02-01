using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class CoinExchange
    {
        public void Notes(int amount)
        {
           // Console.WriteLine(amount + " ");
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] frequency = new int[notes.Length];
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount > notes[i])
                {
                    frequency[i] = amount / notes[i];
                    amount -= notes[i] * frequency[i];
                }
            }
            for (int i = 0; i < notes.Length; i++)
            {
                if(frequency[i]!=0)
                    Console.WriteLine("The Frequency of {0} is {1}",notes[i],frequency[i]);
            }


        }
        public void Change()
        {
            Console.WriteLine("Enter Your Amount\n");
            int amount = Convert.ToInt32(Console.ReadLine());
             Notes(amount);
            

        }
    }
}
