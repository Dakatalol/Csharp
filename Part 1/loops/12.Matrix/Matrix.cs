using System;

class Matrix
{
    static void Main()
    {
        int n;
        Console.Write("Enter a positive integer N(N < 20): ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt && (n > 0 && n < 20))//checking if the boolean variable is "true" and if 'n' is in the required range
        {
            //printing the matrix
            for (int row = 0; row < n; row++)//loop for rows
            {
                for (int col = 0, num = row + 1; col < n; col++, num++)//loop for columns and values
                { 
                    Console.Write("{0,2} ",num);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The entered value must be positive integer smaller than 20!");
        }
    }
}