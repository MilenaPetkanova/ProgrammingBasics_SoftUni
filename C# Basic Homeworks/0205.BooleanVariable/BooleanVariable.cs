using System;
class BooleanVariable
{
    static void Main()
    {
        bool isFemale = true;
        if (isFemale)
        {
            Console.WriteLine(isFemale);
            Console.WriteLine("My gender is a female.");
        }
        else
        {
            Console.WriteLine(!isFemale);
        }
    }
}

//  bool isFemale = true;
//  Console.WriteLine("My gender is a female.");
//  Console.WriteLine(isFemale);

//bool isMale = false;
//Console.WriteLine("My gender is a male.");
//Console.WriteLine(isMale);