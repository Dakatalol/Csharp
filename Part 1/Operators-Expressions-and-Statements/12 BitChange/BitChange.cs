using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_BitChange
{
    class BitChange
    {
        static void Main(string[] args)
        {
            int newValue;
            int v;
            int mask;
            int p;
            Console.Write("Write down the number: ");
            v = int.Parse(Console.ReadLine());
            Console.Write("Set a position of the bit number(counting from 0): ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Write down new value: ");
            newValue = int.Parse(Console.ReadLine());
            if (newValue == 0)
            {

                 mask = ~(1 << p);
                 v = v & mask;
            }
            else
            {
                mask = (1 << p);
                v = v | mask;
            }
            Console.WriteLine("The new value of the number is {0}",v);
        }
    }
}
