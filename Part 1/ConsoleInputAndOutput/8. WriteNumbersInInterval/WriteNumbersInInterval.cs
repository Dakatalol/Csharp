//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
using System;

class WriteNumbersInInterval
{
    static void Main()
    {
        int n;
        Console.Write("Write down the last number of the range: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n+1; i++)
        {
            Console.Write("{0},",i);
        }
         Console.WriteLine("");
    }
}


