using System;

class SortThreeRealValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a >= b && c < a)
        {
            if (b > c)
            {
                Console.WriteLine("{0}, {1}, {2}.", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", a, c, b);
            }
        }
        if (c >= b && a <= c)
        {
            if (b > a)
            {
                Console.WriteLine("{0}, {1}, {2}.", c, b, a);
            }
            else    // a > b
            {
                Console.WriteLine("{0}, {1}, {2}.", c, a, b);
            }
        }
        if (b > a && c < b)
        {
            if (a > c)
            {
                Console.WriteLine("{0}, {1}, {2}.", b, a, c);
            }
            else   // a < c
            {
                Console.WriteLine("{0}, {1}, {2}.", b, c, a);
            }
        }
        Console.WriteLine(new string('-', 40));
        Main();
    }
}