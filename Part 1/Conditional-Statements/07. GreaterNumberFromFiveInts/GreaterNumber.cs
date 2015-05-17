using System;
class GreaterNumber
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        int fourthNumber;
        int fifthNumber;
        Console.Write("Write down the first number : ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the second number : ");
        secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the third number : ");
        thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the fourth number : ");
        fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the fifth number : ");
        fifthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine((Math.Max(Math.Max(Math.Max(Math.Max(firstNumber,secondNumber),thirdNumber),fourthNumber),fifthNumber))); // python style

    }
}

