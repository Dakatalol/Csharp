using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ExchangingBits
{
    class ExBits
    {
        static void Main(string[] args)
        {
            uint num;
            Console.Write("Write down number: ");
            num = uint.Parse(Console.ReadLine());
            int mask = 7;
            int newVal = (mask << 3) & (int)num;
            int newBit = (mask << 24) & (int)num;

            newVal = newVal << 21;
            newBit = newBit >> 21;
            num = (uint)(num & ~(mask << 3));
            num = (uint)(num & ~(mask << 24));
            num = (uint)(num | newVal);
            num = (uint)(num | newBit);

            Console.WriteLine(num);
        }
    }
}
