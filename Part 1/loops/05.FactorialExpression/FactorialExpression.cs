using System;
using System.Numerics;

class FactorialExpression
{
    static void Main()
    {
        int n, k;
        Console.WriteLine("1 < N < K");
        Console.Write("K = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool kInt = int.TryParse(readLine, out k);//boolean variable to check if the entered value is valid
        Console.Write("N = ");
        readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (kInt && nInt && (k > n && n > 1))//checking if both boolean variables are "true", and if 'n' and 'k' are in the required range
        {
            BigInteger nMultByKFact = 1;//declaring a variable for N!*K!
            BigInteger kMinNFact = 1;//declaring a variable for (K-N)!
            for (int i = n; i > 1; i--)//this loop will find the value of N!
            {
                nMultByKFact *= i;
            }
            nMultByKFact *= nMultByKFact;//this will make the value of N! to the power of 2. (N!*N!)
            for (int i = k; i > n; i--)//this loop will multiply with the remaining values <= K and will find N!*K! 
            {
                nMultByKFact *= i;
            }
            for (int i = (k - n); i > 1; i--)//this loop will find (K-N)!
            {
                kMinNFact *= i;
            }
            Console.WriteLine(nMultByKFact / kMinNFact);//(N!*K!)/(K-N)!
        }
        else
        {
            Console.WriteLine("All entered values must be integers! And K > N, N > 0!");
        }
    }
}