using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char a = '\u00A9';
        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine(new string(a, i));
        }
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(new string(a, i));
        }
    }
}
