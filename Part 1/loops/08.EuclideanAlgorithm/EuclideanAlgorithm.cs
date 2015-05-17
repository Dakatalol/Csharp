using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        int number1, number2;
        Console.Write("Number 1 = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool number1Int = int.TryParse(readLine, out number1);//boolean variable to check if the entered value is valid
        Console.Write("Number 2 = ");
        readLine = Console.ReadLine();//getting the entered value
        bool number2Int = int.TryParse(readLine, out number2);//boolean variable to check if the entered value is valid
        if (number1Int && number2Int)//checking if both boolean variables are "true"
        {
            int maxDivisor, swap = 0;
            if (number1 > number2)//checking if the first number is bigger than the second
            {//if so we are swapping them by using a third variable "swap". That way we can keep sure that the second number is the bigger
                swap = number1;
                number1 = number2;
                number2 = swap;
            }
            if (number2 % number1 == 0)//check if the bigger number can be divided by the smaller one without remainder
            {//if so the greatest common divisor is the smaller number
                maxDivisor = number1;
            }
            else
            {
                while (number2 % number1 > 0)//if not this loop is repeated
                {
                    swap = number2 % number1;
                    number2 = number1;
                    number1 = swap;
                }
                maxDivisor = swap;
            }
            Console.WriteLine("The greatest common divisor of both numbers is {0}", maxDivisor);
        }
        else
        {
            Console.WriteLine("All entered values must be integers!");
        }
    }
}