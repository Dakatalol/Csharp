using System;

class SubsetSum
{
    static void Main()
    {
        int[] numbers = new int[5];
        string currentSubset = "";
        bool numInt;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number [{0}] = ", i + 1);
            string readLine = Console.ReadLine();//getting the entered value
            numInt = int.TryParse(readLine, out numbers[i]);//boolean variable to check if the entered value is valid
            if (!numInt)//checking if the boolean variable is "false"
            {//if it is 'i' is decrementing by 1. That way the current iteration of the loop is repeated.
                Console.WriteLine("Invalid value! Try again!");
                i--;
            }
        }
        int subsetAmount = (int)Math.Pow(2, 5);//getting the number of subset combinations that can be formed by the entered numbers
        for (int i = 1; i < subsetAmount; i++)
        {
            currentSubset = "";
            long sum = 0;
            for (int j = 0; j <= numbers.Length; j++)
            {/*using bitwise operations, because in binary all numbers from 1 to (subsetAmount - 1) is showing all the possible subset 
               combinations and can be used as a template, in order to know which numbers to take. Example - 00101 - we will add the first
               and third number to the sum*/
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = iAndMask >> j;
                if (bit == 1)
                {//if the bit at the current position is 1, for example bit - 2(third bit)
                    sum += numbers[j];                    //we are adding the third number to the sum and etc.
                    currentSubset += " " + numbers[j];    //and adding the number to a string
                }
            }
            if (sum == 0)
            {//checking if the current sum is 0.
                Console.WriteLine("The sum of the subset {0} is 0!", currentSubset);
            }
        }
    }
}