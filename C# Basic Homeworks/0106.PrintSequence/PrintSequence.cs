using System;

class PrintASequence
{
    // Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    static void Main()
    {
        Console.WriteLine("First 10 members of a sequence:");
        for (short i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}