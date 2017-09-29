using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum is: {0}.", a + b + c);
    }
}
