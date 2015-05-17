using System;

class QuotedString
{
    static void Main()
    {
        string a1 = "The "+ (char)34 + "use" + (char)34 + " of quotations causes difficulties."; //using "typecasting" for "
        string a2 = "The \"use\" of quotations causes difficulties."; //using quotation
        Console.WriteLine(a1);
        Console.WriteLine(a2);
    }
}
