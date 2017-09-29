using System;

class SumOf5Numbers
{
    // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers in a single line, separated by a space: ");
        string[] theNumber = Console.ReadLine().Split();
        double a = Convert.ToDouble(theNumber[0]);
        double b = Convert.ToDouble(theNumber[1]);
        double c = Convert.ToDouble(theNumber[2]);
        double d = Convert.ToDouble(theNumber[3]);
        double e = Convert.ToDouble(theNumber[4]);

        double sumOfAll = a + b + c + d + e;
        Console.WriteLine(sumOfAll);
    }
}


