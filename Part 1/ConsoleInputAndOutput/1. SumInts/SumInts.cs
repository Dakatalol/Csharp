//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;

class SumInts
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        Console.Write("Write down the first number: ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the second number : ");
        secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the third number : ");
        thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of {0}, {1} and {2} is {3} .", firstNumber, secondNumber, thirdNumber, firstNumber+secondNumber+thirdNumber);
    }
}

