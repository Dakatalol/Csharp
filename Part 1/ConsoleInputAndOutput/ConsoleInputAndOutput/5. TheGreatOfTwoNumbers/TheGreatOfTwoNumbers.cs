//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
using System;

class TheGreatOfTwoNumbers
{
    static void Main()
    {
        int firstNum;
        int secondNum;
        int greatNumber;
        Console.Write("Write down the first number: ");
        firstNum = int.Parse(Console.ReadLine());
        Console.Write("Write down the second number: ");
        secondNum = int.Parse(Console.ReadLine());
        greatNumber = Math.Max(firstNum, secondNum);
        Console.WriteLine("The great of {0} and {1} is {2}",firstNum,secondNum,greatNumber);
    }
}
