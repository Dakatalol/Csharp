//Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
	//	Use a switch statement and at the end print the calculated new value in the console.

using System;
class BonusScoresForDigits
{
    static void Main()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Bonus Scores: ");
        Console.Write("From 1-3 x10, 4-6 x100, 7-9 x1000");
        Console.WriteLine(new string('-', 40));
        int digit;
        Console.Write("Write the digit:  ");
        digit = int.Parse(Console.ReadLine());
        switch (digit)
        {

            case 1: 
            case 2: 
            case 3: Console.WriteLine("Bonus of{0} is : {1}", digit, digit * 10); break;
            case 4: 
            case 5: 
            case 6: Console.WriteLine("Bonus of{0} is : {1}", digit, digit * 100); break;
            case 7: 
            case 8: 
            case 9: Console.WriteLine("Bonus of{0} is : {1}", digit, digit * 1000); break;

            default:
                break;
        }
    }
}

