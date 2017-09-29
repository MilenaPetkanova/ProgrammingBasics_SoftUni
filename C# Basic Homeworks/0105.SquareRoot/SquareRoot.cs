using System;
class SuareRoot
{
    // Create a console application that calculates and prints the square root of the number 12345. 
    // Find in Internet “how to calculate square root in C#”.
    static void Main()
    {
        double sqrtRoot = Math.Sqrt(12345);
        Console.WriteLine("The square root of the number 12345 is {0}", sqrtRoot);
    }
    
// ?? Debugging 

// Another one:
using System;
class SquareRoot
{
    static void Main()
    {
        int n = 12345;
        Console.WriteLine(Math.Sqrt(n));
    }
}

//




// Same here:
using System;
class SuareRoot
{
    static double[] _lookup = new double[5];

    static void Main()
    {
        double a = Math.Sqrt(12345);

        var lookup = _lookup;
        lookup[1] = a;

        Console.WriteLine(lookup[1]);
    }
}

