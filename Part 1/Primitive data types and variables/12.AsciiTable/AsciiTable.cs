using System;

class AsciiTable
{
    static void Main()
    {
        string asciiString;
        char asciiChar;
        for (int i = 0; i < 128; i++)
        {
            asciiChar = (char)i;
            asciiString = asciiChar.ToString();
            if (char.IsWhiteSpace(asciiChar)) //Checking if "asciiChar" is a "white space" char (tab/space/etc.)
            {
                switch (asciiChar) //Checking each case of "white space" char and assingning its value to "asciiString" 
                {
                    case '\t':
                        asciiString = "\\t";
                        break;
                    case ' ':
                        asciiString = "space";
                        break;
                    case '\n':
                        asciiString = "\\n";
                        break;
                    case '\r':
                        asciiString = "\\r";
                        break;
                    case '\v':
                        asciiString = "\\v";
                        break;
                    case '\f':
                        asciiString = "\\f";
                        break;
                }
            }
            else if (char.IsControl(asciiChar)) //Checking if "asciiChar" is a "control/reserved" char
            {
                asciiString = "control character";
            }
            else
            {
                asciiString = asciiChar.ToString();
            }
            Console.WriteLine(asciiString);
        }
    }
}