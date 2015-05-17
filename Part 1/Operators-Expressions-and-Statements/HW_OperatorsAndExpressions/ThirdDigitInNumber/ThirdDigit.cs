using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitInNumber
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Write down the number: ");
            number = int.Parse(Console.ReadLine());

            number = Math.Abs(number / 100);  // with Math.Abs we can calculate negative numbers
            if (number % 10 == 7)
            {
                Console.WriteLine("The /THIRD/(right->left) digit of the number is 7");
            }
            else
            {
                Console.WriteLine("The /THIRD/(right->left) digit of the number is /NOT/ 7");
            }
        }
    }
}
