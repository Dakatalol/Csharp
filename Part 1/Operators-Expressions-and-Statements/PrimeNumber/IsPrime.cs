using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool prime = true;
            // we only have to count up to and including the square root of a number
            int upper = (int)Math.Sqrt(number);
            for (int i = 2; i <= upper; i++)
            {
                if ((number % i) == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine("Number {0} is " + (prime ? "prime" : "not prime"), number);
        }
    }
}
