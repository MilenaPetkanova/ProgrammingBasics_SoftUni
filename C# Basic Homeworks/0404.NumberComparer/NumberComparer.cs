using System;
class NumberComparer
{
    // Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.
    static void Main()
    {
        Console.WriteLine("Enter two numbers to compare: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a <= b)
        {
            Console.WriteLine("The greater of them is: {0}", b);
        }
        else if (b < a)
        {
            Console.WriteLine("The greater of them is: {0}", a);
        }

    }
}

