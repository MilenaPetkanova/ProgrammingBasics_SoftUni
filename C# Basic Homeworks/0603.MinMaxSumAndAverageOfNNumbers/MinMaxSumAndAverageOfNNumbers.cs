using System;

class MinMaxSumAndAverageOfNNumbers
{
    // Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and 
    // the average of all numbers (displayed with 2 digits after the decimal point). 
    // The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayOfNumbers);
        Console.WriteLine("min = {0}", arrayOfNumbers[0]);
        Console.WriteLine("max = {0}", arrayOfNumbers[n - 1]);

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arrayOfNumbers[i];
        }
        Console.WriteLine("sum = {0}", sum);

        double avg = sum / n;
        Console.WriteLine("avg = {0:F2}", avg);
    }
}
