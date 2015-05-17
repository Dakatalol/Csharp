using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfGivenBitNumber
{
    class ValueOfGivenBitNumber
    {
        static void Main(string[] args)
        {

            int mask;
            int v;
            int p;
            Console.Write("Write down the number: ");
            v = int.Parse(Console.ReadLine());
            Console.Write("Set a position of the bit number(counting from 0): ");
            p = int.Parse(Console.ReadLine());
            mask = 1 << p;
            int vAndMask = v & mask;
            int bit = vAndMask >> p;
            Console.WriteLine(bit);
        }
    }
}
