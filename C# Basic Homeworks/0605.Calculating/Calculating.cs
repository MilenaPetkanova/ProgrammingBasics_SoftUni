using System;

class Calculating
{
    // Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
    // Use only one loop. Print the result with 5 digits after the decimal point.
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double nFactorial = 1;
        double xPoweredByN = x;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            double result = nFactorial / xPoweredByN;
            sum += result;
            xPoweredByN *= x;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
