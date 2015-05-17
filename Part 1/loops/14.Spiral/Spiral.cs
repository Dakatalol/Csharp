using System;

class Spiral
{
    static void Main()
    {
        int n;
        Console.Write("Enter a positive integer N(N < 20): ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt && (n > 0 && n < 20))//checking if the boolean variable is "true" and if 'n' is in the required range
        {
            int[,] spiral = new int[n,n];//declaring a two dimensional array(matrix)
            int num = 1;//starting value
            int count = n;//current number of values to be written on the row/column
            int movesCount = n * 2;//number of changes of direction
            int row = 0, col = 0;//starting coordinates
            int dirChange = -1;//ascending(-1) or descending(1) the current value(num)
            string[] directions = { "up", "right", "down", "left" };
            for (int currentMove = 1; currentMove < movesCount; currentMove++)//loop for all the moves
            {
                if (currentMove % 2 == 0)
                {
                    count--;     // Decrease size of next move
                }
                else
                {
                    dirChange *= -1;  // Change direction of move
                }
                for (int i = 0; i < count; i++)//loop for the current number of values to be written
                {
                    switch (directions[currentMove % 4])//checking case of direction and filling the matrix
                    {
                        case "right":
                        case "left":
                            col += dirChange;
                            spiral[row, col - 1] = num;
                            break;
                        case "down":
                        case "up":
                            row += dirChange;
                            spiral[row, col - 1] = num;
                            break;
                    }
                    num++;
                }
            }
            //printing the matrix
            for (int i = 0; i < n; i++)//loop for rows
            {
                for (int j = 0; j < n; j++)//loop for columns
                {
                    Console.Write("{0,3} ", spiral[i, j]);
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