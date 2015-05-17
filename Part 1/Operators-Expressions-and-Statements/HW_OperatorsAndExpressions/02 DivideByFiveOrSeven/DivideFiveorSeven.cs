using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DivideByFiveOrSeven
{
    class DivideFiveorSeven
    {
        static void Main(string[] args)
        {
            int number;
            bool check;
            Console.Write("Write down the number you want to check: ");
            number = int.Parse(Console.ReadLine());
            check = (number % 5 % 7 == 0);
            if (check == true)
            {
                Console.WriteLine("The number you've written can be divide by 5 & 7");
            }
            else
            {
                Console.WriteLine("The number you've written can't be divded by 5&7");
            }
        }
    }
}
