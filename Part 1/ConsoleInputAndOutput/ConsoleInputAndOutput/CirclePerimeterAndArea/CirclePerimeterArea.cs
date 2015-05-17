//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double pi = Math.PI;
        double radius;
        double circleArea;
        double circlePerimeter;
        Console.Write("Write down the radius of the circle: ");
        radius = double.Parse(Console.ReadLine());

        circleArea = pi * (radius * radius);
        circlePerimeter = 2 * pi * radius;
        Console.WriteLine("The circle with the radius {0} is with Area={1:F2} and Perimeter={2:F2}",radius,circleArea,circlePerimeter);
    }
}

