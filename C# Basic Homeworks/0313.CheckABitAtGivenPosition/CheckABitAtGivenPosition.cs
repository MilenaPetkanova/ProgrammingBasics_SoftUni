using System;

class CheckABitAtGivenPosition
{
    // Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
    // in given integer number n has value of 1. 
    static void Main()
    {
        Console.WriteLine("Enter integer number and and index (n, p)");
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine((n & (1 << p)) > 0 ? true : false);
    }
}

// Same result here:

// Console.WriteLine("Enter integer number and and index (n, p)");
// int n = int.Parse(Console.ReadLine());
// int p = int.Parse(Console.ReadLine());
// bool isOne = (n & (1 << p)) > 0;
// Console.WriteLine(isOne);