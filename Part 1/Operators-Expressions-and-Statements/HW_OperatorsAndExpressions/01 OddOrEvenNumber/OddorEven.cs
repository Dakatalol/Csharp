using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OddOrEvenNumber
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Write down the number you want to check: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

        }
    }
}
