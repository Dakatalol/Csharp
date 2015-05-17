using System;
using System.Numerics;

class SAndXSum
{
    static void Main()
    {
        int n, x;
        Console.Write("N = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        Console.Write("X = ");
        readLine = Console.ReadLine();//getting the entered value
        bool kInt = int.TryParse(readLine, out x);//boolean variable to check if the entered value is valid
        if (nInt && kInt)//checking if both boolean variables are "true"
        {
            decimal nFact = 1;//declaring a variable for current N!
            decimal xPow = 1;//declaring a variable for current X^N
            decimal sum = 1;//declaring a variable for current sum
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                xPow *= x;
                sum += (nFact / xPow);
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("All entered values must be integers!");
        }
    }
}