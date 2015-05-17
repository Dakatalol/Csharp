//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;
class SignOfThreeRealNumbers
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

        if (firstNumber > 0)
        {
            Console.WriteLine("The first number {0} is with positive sign(+)", firstNumber);
        }
        else
        {
            Console.WriteLine("The first number {0} is with negative sign(-)", firstNumber);
        }

        if (secondNumber > 0)
        {
            Console.WriteLine("The second number {0} is with positive sign(+)", secondNumber);
        }
        else
        {
            Console.WriteLine("The second number {0} is with negative sign(-)", secondNumber);
        }
        if (thirdNumber > 0)
        {
            Console.WriteLine("The third number {0} is with positive sign(+)", thirdNumber);
        }
        else
        {
            Console.WriteLine("The third number {0} is with negative sign(-)", thirdNumber);
        }
    }
}

