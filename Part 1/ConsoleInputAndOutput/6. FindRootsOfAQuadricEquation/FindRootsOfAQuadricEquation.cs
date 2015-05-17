//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
using System;

class FindRootsOfAQuadricEquation
{
    static int Main()
    {
        int a;
        int b;
        int c;
        double discriminant;
        double firstRoot;
        double secondRoot;

        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = int.Parse(Console.ReadLine());

        discriminant = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine("Discriminant: {0}", discriminant);
        if (discriminant < 0)  // checking if discriminant is negative
        {
            Console.WriteLine("Discriminat is /NEGATIVE/. There are no real roots" );
            return -1; 
        }

        if (discriminant == 0) // checking if discriminant is 0.
        {
            firstRoot = secondRoot = -(b / 2 * a);
            Console.WriteLine("Both of the roots are equal since discriminat is 0.");
            Console.WriteLine("First Root=Second Root = {0}",firstRoot);
            return -1;
        }
        else //calculating fist and second root of the Equation.
        {
            firstRoot = (-b + Math.Sqrt(discriminant))/2*a;
            secondRoot = (-b - Math.Sqrt(discriminant)) / 2 * a;
        }

        Console.WriteLine("Equation: {0}x+{1}x^2+{2}=0",a,b,c);
        Console.WriteLine("First Root: {0} ", firstRoot);
        Console.WriteLine("Second Root: {0} ", secondRoot);
        return 0;

    }
}

