using System;
using System.Numerics;
class SimpleLoops
{
    static void Main()
    {
        BigInteger firstElement = BigInteger.Parse(Console.ReadLine());
        BigInteger secondElement = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdElement = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger nextElement = 0;

        if (n == 1)
        {
            Console.WriteLine(firstElement);
        }
        else if (n == 2)
        {
            Console.WriteLine(secondElement);
        }
        else if (n == 3)
        {
            Console.WriteLine(thirdElement);
        }
        else
        {
            for (int i = 1; i <= n - 3; i++)
            {
                nextElement = firstElement + secondElement + thirdElement;
                firstElement = secondElement;
                secondElement = thirdElement;
                thirdElement = nextElement;
            }
            Console.WriteLine(nextElement);   
        }
    }
}
