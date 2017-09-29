using System;
using System.Collections.Generic;
using System.Linq;

class Pairs
{
    // You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, 
    // the third and the fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. 
    // Your task is to write a program to check whether all pairs have the same value or print the max difference between two consecutive values.
    static void Main()
    {
        Console.WriteLine("Enter pairs of integer numbers:");
        string sequence = Console.ReadLine();
        string[] array = sequence.Split(' ');
        List<int> sum = new List<int>();
        for (int i = 0; i < (array.Length); i += 2)
        {
            int x = Convert.ToInt32(array[i]);
            int y = Convert.ToInt32(array[i + 1]);
            int sumXandY = x + y;
            sum.Add(sumXandY);
            Console.WriteLine(sumXandY);

            int max = sum.Max();
            if (max == (sum.Min()))
            {
                Console.WriteLine("Yes, value=" + sum[0]);
                return;
            }
            else
                Console.WriteLine("No, maxdiff=" + (max - sum.Min()));
        }
    }
}

