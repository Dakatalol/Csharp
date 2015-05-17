using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            double trapArea;
            Console.Write("Write down a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Write down b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Write down h: ");
            h = double.Parse(Console.ReadLine());

            trapArea = (0.5 * (a + b)) * h;

            Console.WriteLine("The Trapezoid Area is {0}",trapArea);
        }
    }
}
