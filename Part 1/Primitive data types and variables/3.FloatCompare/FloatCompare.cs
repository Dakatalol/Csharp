using System;

class FloatCompare
{
    static void Main()
    {
        Console.Write("Number 1 = ");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.Write("Number 2 = ");
        decimal number2 = decimal.Parse(Console.ReadLine());
        number1 = Math.Round(number1, 6); //rounding "number1" to 0.000001 precision
        number2 = Math.Round(number2, 6); //rounding "number2" to 0.000001 precision
        bool equal = (number1 == number2); //checking if they are equal
        Console.WriteLine(equal);
    }
}
