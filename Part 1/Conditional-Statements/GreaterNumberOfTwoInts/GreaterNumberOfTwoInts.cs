//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;
class GreaterNumberOfTwoInts
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int greaterNumber;
        Console.Write("Write down the first number: ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the second number: ");
        secondNumber = int.Parse(Console.ReadLine());
        greaterNumber = firstNumber;
        if (secondNumber > greaterNumber) 
        {
            greaterNumber = secondNumber;
        }
        Console.WriteLine("The greater number is {0}", greaterNumber);
    }
}

