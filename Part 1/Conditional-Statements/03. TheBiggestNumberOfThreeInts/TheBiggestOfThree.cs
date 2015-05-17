//Write a program that finds the biggest of three integers using nested if statements.

using System;
class TheBiggestOfThree
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        Console.Write("Write down the first number : ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the second number : ");
        secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the third number : ");
        thirdNumber = int.Parse(Console.ReadLine());

        int biggestNumber = firstNumber;

        if (biggestNumber < secondNumber)
        {
            biggestNumber = firstNumber;
            if (biggestNumber < thirdNumber)
            {
                biggestNumber = thirdNumber;
            }
        }
        else if (biggestNumber < thirdNumber)
        {
            if (biggestNumber < thirdNumber)
            {
                biggestNumber = thirdNumber;
            }
        }
        Console.WriteLine("The biggest number of {0}, {1} and {2} is : {3}", firstNumber, secondNumber, thirdNumber, biggestNumber);
    }
}

