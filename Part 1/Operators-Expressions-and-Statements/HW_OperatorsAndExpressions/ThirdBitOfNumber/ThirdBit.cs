using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBitOfNumber
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Write down the number: ");
            number = int.Parse(Console.ReadLine());
            number = number >> 3;
            if (number % 2 == 0)
            {
                Console.WriteLine("The third bit of the number is {0}", number);
            }
            else
            {
                Console.WriteLine("The third bit of the number is {0}", number);
            }
         }
    }
}
