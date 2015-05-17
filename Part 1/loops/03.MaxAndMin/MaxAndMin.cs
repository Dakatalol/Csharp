using System;

class MaxAndMin
{
    static void Main()
    {
        int n;
        Console.Write("N = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt)//checking if the boolean variable is "true"
        {
            int[] numSequence = new int[n];//declaring an int array with 'n' members
            bool numInt;
            for (int i = 0; i < numSequence.Length; i++)
            {
                Console.Write("Number [{0}] = ", i + 1);
                readLine = Console.ReadLine();//getting the entered value
                numInt = int.TryParse(readLine, out numSequence[i]);//boolean variable to check if the entered value is valid
                if (!numInt)//checking if the boolean variable is "false"
                {//if it is 'i' is decrementing by 1 and the current iteration of the loop is repeated.
                    Console.WriteLine("Invalid value! Must be integer!");
                    i--;
                }
            }
            int max = numSequence[0], min = numSequence[0];//temporary assigning the first member of the array both as min and max value.
            for (int i = 0; i < numSequence.Length; i++)
            {
                if (numSequence[i] > max)//checking if the current member is bigger than the current max value
                {//if it is max takes the value of the current member of the array
                    max = numSequence[i];
                }
                if (numSequence[i] < min)//checking if the current member is smaller than the current min value
                {//if it is min takes the value of the current member of the array
                    min = numSequence[i];
                }
            }
            Console.WriteLine("Max value = {0}  Min value = {1} ", max, min);
        }
        else
        {
            Console.WriteLine("The entered value must be integer!");
        }
    }
}