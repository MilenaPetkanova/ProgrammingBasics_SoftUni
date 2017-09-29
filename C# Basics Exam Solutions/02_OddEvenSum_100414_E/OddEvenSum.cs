using System;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int sumOdd = 0;
        int sumEven = 0;

        bool odd = true;
        for (int i = 0; i < 2*n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (odd)
            {
                sumOdd += element;
            }
            else
            {
                sumEven += element;
            }
            odd = !odd;
        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            int diff = sumOdd - sumEven;
            if (diff < 0)
            {
                diff *= -1;
            }
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
