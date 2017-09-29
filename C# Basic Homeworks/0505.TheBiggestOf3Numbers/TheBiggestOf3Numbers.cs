using System;

class TheBiggestOf3Numbers
{
    // Write a program that finds the biggest of three numbers.
    static void Main()
    {
        Console.WriteLine("Enter three numbers to compare:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest is {0}", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The biggest is {0}", b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine("The biggest is {0}", c);
        }
    }
}
