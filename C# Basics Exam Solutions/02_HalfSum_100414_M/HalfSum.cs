using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int firstSum = 0;
        int secondSum = 0;

        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            firstSum += element;
        }
        for (int i = n; i < 2*n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            secondSum += element;
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            int diff = Math.Abs(firstSum - secondSum);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
