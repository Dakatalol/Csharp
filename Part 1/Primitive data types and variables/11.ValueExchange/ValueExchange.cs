using System;

class ValueExchange
{
    static void Main()
    {
        int x = 5, y = 10, swap;
        Console.WriteLine("x = {0}; y = {1}", x, y);
        //Exchanging values by using a third variable "swap"
        swap = y;
        y = x;
        x = swap;
        Console.WriteLine("x = {0}; y = {1}", x, y);
    }
}