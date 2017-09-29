using System;

class SumOfNumbers
{
    // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
    static void Main()
    {
        Console.WriteLine("\tSUM OF N NUMBERS");
        Console.WriteLine("\t****************");
        Console.WriteLine("Enter how nany numbers to calculate: ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers one by one: ");
        decimal sum = 0.0m;
        decimal number = decimal.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of your numbers is: {0}", sum);
    }
}




