using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        int n;
        Console.Write("Which Catalan number? :  ");
        string readLine = Console.ReadLine();//getting the entered value
        bool nInt = int.TryParse(readLine, out n);//boolean variable to check if the entered value is valid
        if (nInt)//checking if the boolean variable is "true"
        {
            BigInteger nFact = 1;//declaring a variable for N!
            BigInteger nPlus1Fact = 1;//declaring a variable for (N+1)!
            BigInteger nMulti2Fact = 1;//declaring a variable for (2*N)!
            BigInteger catNumber;//declaring a variable for the wanted Catalan number
            for (int i = 1; i <= n; i++)//findinng N!
            {
                nFact *= i;
            }
            nPlus1Fact = nFact * (n + 1);//finding (N+1)!
            nMulti2Fact = nFact;//assigning initial value
            for (int i = (n + 1); i <= (2 * n); i++)//and multiplying it with the remaining values <=2*N, in order to find (2*N)!
            {
                nMulti2Fact *= i;
            }
            catNumber = nMulti2Fact / (nPlus1Fact * nFact);//finding the wanted Catalan number
            Console.WriteLine("Catalan number {0} = {1}", n, catNumber);
        }
        else
        {
            Console.WriteLine("The entered value must be integer!");
        }
    }
}