using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PointOutOfRectangleAndWithinCircle
{
    class PointOutOfRectangleAndWithinCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cicle K((1,1),3)");
            Console.WriteLine("Rectangle R(top = 1, left = -1, width = 6, height = 2)");
            double radius = 3, pointX, pointY;
            Console.Write("Point coordinate 'x' = ");
            string readLine = Console.ReadLine(); //getting the entered value
            bool pointXDouble = double.TryParse(readLine, out pointX); //boolean variable to check if the entered value is valid
            Console.Write("Point coordinate 'y' = ");
            readLine = Console.ReadLine(); //getting the entered value
            bool pointYDouble = double.TryParse(readLine, out pointY); //boolean variable to check if the entered value is valid
            if (pointXDouble && pointYDouble) //checking if both boolean variables are "true"
            {
                double xNew = pointX - 1, yNew = pointY - 1; //adjusting xNew and yNew depending from the center of the circle
                //checking if both coordinates of the point are in th circle.
                if ((xNew * xNew) + (yNew * yNew) <= (radius * radius))
                {
                    Console.WriteLine("The point is within the circle");
                }
                else
                {
                    Console.WriteLine("The point is out of the circle");
                }
                //boolean variable to check if xNew out of the rectangle.
                bool xOut = ((pointX < (-1)) || (pointX > 5));
                //boolean variable to check if yNew out of the rectangle.
                bool yOut = ((pointY > 1) || (pointY < (-1)));
                if (xOut || yOut) //checking if one of the boolean variables is "true"
                {
                    Console.WriteLine("The point is out of the rectangle");
                }
                else if (!xOut && !yOut)//checking if both boolean variables are "false"
                {
                    Console.WriteLine("The point is within the rectangle");
                }
            }
            else
            {
                Console.WriteLine("All entered values must be numbers!");
            }
        }
    }
}
