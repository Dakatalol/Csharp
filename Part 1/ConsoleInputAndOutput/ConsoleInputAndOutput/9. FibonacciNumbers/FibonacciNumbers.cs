//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;

class FibonacciNumbers
{
    static void Main()
    {
        int previous = -1;
        int next = 1;
        for (int i = 0; i < 101; i++)
        {
            int sum = next + previous;
            previous = next;
            next = sum;
            Console.WriteLine(next);
        }  

    }
}

