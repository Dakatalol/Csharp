using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateRectangleArea
{
    class CalculateRectangle
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            int rectArea;
            Console.Write("Height:");
            height = int.Parse(Console.ReadLine());
            Console.Write("Width:");
            width = int.Parse(Console.ReadLine());

            rectArea = width * height;
            Console.WriteLine("Rectangle are is {0}",rectArea);
        }
    }
}
