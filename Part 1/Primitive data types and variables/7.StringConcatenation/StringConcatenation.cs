using System;

class StringConcatenation
{
    static void Main()
    {
        string hello = "Hello", world = "World";
        object helloWorld = hello + " " + world;
        string helloWorld2 = (string)helloWorld;
        Console.WriteLine(helloWorld2);
    }
}
