using System;

class Print1ToN
{
    static void Main()
    {
        int n;
        Console.Write("N = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt)//checking if the boolean variable is "true"
        {
            if (n > 0)//checking the sign of 'n'
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i >= n; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("The entered value must be integer!");
        }
    }
}