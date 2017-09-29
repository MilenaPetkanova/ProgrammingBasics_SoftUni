using System;
class Pairs_SecondVersion
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] elements = inputLine.Split(' ');

        int[] pairs = new int[elements.Length];

        int maxPairsValue = int.MinValue;
        int minPairsValue = int.MaxValue;

        for (int i = 0; i < elements.Length; i += 2)
        {
            pairs[i / 2] = int.Parse(elements[i]) + int.Parse(elements[i + 1]);
            if (pairs[i / 2] > maxPairsValue)
            {
                maxPairsValue = pairs[i / 2];
            }
            if (pairs[i / 2] < minPairsValue)
            {
                minPairsValue = pairs[i / 2];
            }
        }

        int maxdiff = maxPairsValue - minPairsValue;

        Console.WriteLine("maxPairsValue = " + maxPairsValue);
        Console.WriteLine("minPairsValue = " + minPairsValue);

        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value={0}", maxPairsValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }
    }
}
