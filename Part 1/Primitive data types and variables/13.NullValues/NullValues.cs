using System;

class NullValues
{
    static void Main()
    {
        int? x = null;
        double? y = null;
        Console.WriteLine(x);
        Console.WriteLine(y);
        x = x + 5;
        y = y + 10.16;
        Console.WriteLine(x);
        Console.WriteLine(y);
        x = x + null;
        y = y + null;
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}