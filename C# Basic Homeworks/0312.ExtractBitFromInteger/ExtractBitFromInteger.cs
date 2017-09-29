using System;

class ExtractBitFromInteger
{
    // Write an expression that extracts from given integer n the value of given bit at index p. 
    static void Main()
    {
        Console.WriteLine("Enter integer value and index (n, p)");
        uint number = byte.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        uint mask = 1;

        Console.WriteLine((mask << p & number) == 0 ? "0" : "1");
    }
}
