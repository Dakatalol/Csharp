using System;
using System.Numerics;
using System.Diagnostics;

class FibonacciSum
{
    static void Main()
    {
        int n;
        Console.Write("The sum of how many Fibonacci members = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt)//checking if the boolean variable is "true"
        {
            BigInteger first = 0, second = 1, current, sum;//declaring variables for the first, second and current members and the sum=
            if (n == 1)
            {
                sum = 0;
            }
            else if (n == 2)
            {
                sum = 1;
            }
            else
            {
                sum = 1;
                for (int i = 3; i <= n; i++)
                {
                    current = first + second;//the current member gets the value of first + second
                    sum += current;
                    first = second;
                    second = current;
                }
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("The entered value must be integer!");
        }
    }
}