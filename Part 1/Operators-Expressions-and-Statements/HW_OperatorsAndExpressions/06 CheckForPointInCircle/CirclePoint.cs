using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CheckForPointInCircle
{
    class CirclePoint
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int r;
            Console.Write("Write down X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Write down X: ");
            y = int.Parse(Console.ReadLine());
            r = 5; // radius (0,5)

            if ((x * x + y * y) < r * r)
            {
                Console.WriteLine("The written X={0} & Y={1} are within the circle K(0,5)",x,y);
            }
            else
            {
                Console.WriteLine("The written X={0} & Y={1} are not within the circle K(0,5)", x, y);
            }
        }
    }
}
