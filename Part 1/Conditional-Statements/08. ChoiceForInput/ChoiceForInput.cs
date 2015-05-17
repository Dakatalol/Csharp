using System;

class ChoiceForInput
{
    static void Main()
    {
        Console.WriteLine("Enter 0 for int, 1 for double, and 2 for string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 0: int firstChoise = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoise + 1);
                break;
            case 1: double secondChoise = double.Parse(Console.ReadLine());
                Console.WriteLine(secondChoise + 1);
                break;
            case 2: string thirdChoise = Console.ReadLine();
                Console.WriteLine(thirdChoise + "*");
                break;
            default: Console.WriteLine("Problem, problem");
                break;
        }
    }
}