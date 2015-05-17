/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive).
Example: p(17,25) = 2.*/
using System;

class NumbersExistingInRange
    {
        static void Main()
        {
            int firstNum;
            int secondNum;
            Console.Write("Please write down the first positive number: ");
            firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please write down the second positive number: ");
            secondNum = int.Parse(Console.ReadLine());
            int counter = 0;
            
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (firstNum == 0 && secondNum == 0)
                {
                    Console.WriteLine("Min and max can't be 0");
                    break;
                }
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("The count of numbers devidable by 5 without remainder from {0} to {1} is {2}", firstNum, secondNum, counter);
        }
    }

