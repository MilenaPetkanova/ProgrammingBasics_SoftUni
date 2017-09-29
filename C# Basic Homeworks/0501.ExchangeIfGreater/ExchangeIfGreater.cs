using System;

class ExchangeIfGreater
{
    // Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one.
    // As a result print the values a and b, separated by a space. 
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            // Console.WriteLine("The first number is greater than the second.");
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            // Console.WriteLine("The first number isn't greater than the second.");
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
