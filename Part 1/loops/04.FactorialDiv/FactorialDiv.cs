using System;
using System.Numerics;

class FactorialDiv
{
    static void Main()
    {
        int n, k;
        Console.WriteLine("1 < K < N");
        Console.Write("N = ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        Console.Write("K = ");
        readLine = Console.ReadLine();//getting the entered value
        bool kInt = int.TryParse(readLine, out k);//boolean variable to check if the entered value is valid
        if (nInt && kInt && (n > k && k > 1))//checking if both boolean variables are "true", and if 'n' and 'k' are in the required range
        {
            BigInteger nDivByKFact = 1;//declaring a variable for N!/K!
            for (int i = n; i > k; i--)//finding the value of N!/K!. Starting from 'n' and finishing with k + 1, because it is the same 
            {                          //as finding N! and K! separately and dividing N! by K!.
                nDivByKFact *= i;
            }
            Console.WriteLine(nDivByKFact);
        }
        else
        {
            Console.WriteLine("All entered values must be integers! And N > K, K > 0!");
        }
    }
}