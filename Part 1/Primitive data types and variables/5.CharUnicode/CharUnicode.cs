using System;

class CharUnicode
{
    static void Main()
    {
        char a1 = '\u0048'; //using direct representaion in UTF-16
        char a2 = (char)72; // using "typecasting"
        Console.WriteLine(a1); 
        Console.WriteLine(a2);
    }
}