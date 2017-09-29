using System;

class BitwiseExtractBit3
{
    // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
    // The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
    static void Main()
    {
        Console.WriteLine("Enter unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;

        Console.WriteLine((mask << 3 & number) == 0 ? "0" : "1");
    }
}


// Another one:
using System;
class Program
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rightBit = n >> 3;
        int bit = rightBit & 1;
        Console.WriteLine(bit);
    }
}