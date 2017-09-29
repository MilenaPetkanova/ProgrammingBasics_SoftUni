using System;
using System.Linq;
using System.Numerics;

class SumOfElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        BigInteger[] numbers = Array.ConvertAll(input, BigInteger.Parse);

        BigInteger biggestNumber = numbers.Max();

        BigInteger sum = 0;

        foreach (BigInteger element in numbers) 
        {
            sum += element;
        }
        sum -= biggestNumber;

        if (sum == biggestNumber)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            if (sum > biggestNumber)
            {
                Console.WriteLine("No, diff={0}", sum - biggestNumber);
            }
            else if (biggestNumber > sum)
            {
                Console.WriteLine("No, diff={0}", biggestNumber - sum);
            }
        }
    }
}
