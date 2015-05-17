using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        int n;
        Console.Write("N = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt)//checking if the boolean variable is "true"
        {
            //this part will find and print N! just to make sure if the resul is correct. It's not necessary for the program to work.
            /*BigInteger nFact = 1;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }
            Console.WriteLine(nFact);*/
            int primeDivBy5;//declaring a variable for current prime divisor of value 5
            int zeroCount = 0;//declaring a variable for current number of trailing zeros
            while (true)
            {
                primeDivBy5 = n / 5;//finding current prime divisor of value 5
                if (primeDivBy5 != 0)//if it's different than 0 zeroCount is incrementing by primeDivBy5
                {
                    zeroCount += primeDivBy5;
                    n = primeDivBy5;//and 'n' takes the value of primeDivBy5
                }
                else
                {//if not the loop stops
                    break;
                }
            }
            Console.WriteLine("Trailing zeros: " + zeroCount);
        }
        else
        {
            Console.WriteLine("The entered value must be integer!");
        }
    }
}