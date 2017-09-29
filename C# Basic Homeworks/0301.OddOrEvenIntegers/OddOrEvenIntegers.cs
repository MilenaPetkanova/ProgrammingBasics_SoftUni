using System;
class OddOrEvenIntegers
{
    // Write an expression that checks if given integer is odd or even.
    private static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the number odd?");
        Console.WriteLine(n % 2 == 1);
    }
}

// Another one:
//      Console.WriteLine("Enter a number: ");
//        int n = int.Parse(Console.ReadLine());
//        bool isOdd = n % 2 == 1 ? true : false;
//        Console.WriteLine("Is the number odd?");
//        Console.WriteLine(isOdd);
//        