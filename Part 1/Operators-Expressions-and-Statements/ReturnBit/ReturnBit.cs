using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnBit
{
    class ReturnBit
    {
        static void Main(string[] args)
        {
            
            int mask;
            int v;
            bool bitIs1;
            int p;
            int vAndMask;
            int bit;
            Console.Write("Write down the number: ");
            v = int.Parse(Console.ReadLine());
            Console.Write("Set a position of the bit number(counting from 0): ");
            p = int.Parse(Console.ReadLine());
            mask = 1 << p;
            vAndMask = v & mask;
            bit = vAndMask >> p;
            bitIs1 = (bit == 1);
            Console.WriteLine("The statement that the bit at the {0} position is /ONE/ is " +  (bitIs1? "true." : "not true." ),p);
            
        }
    }
}
