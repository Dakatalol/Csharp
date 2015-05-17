//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
using System;

class GetMoreN
{
    static void Main()
    {
        int n;
        int sum = 0;
        int number;
        Console.Write("Write down the number of the values you want sum'd: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Write down the {0} value:",i);
            number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of your desired numbers is: {0} ", sum);
    }
}

