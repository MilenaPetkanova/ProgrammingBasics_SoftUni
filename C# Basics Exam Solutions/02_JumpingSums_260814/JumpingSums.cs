using System;
class JumpingSums
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');
        int jumps = int.Parse(Console.ReadLine());

        int[] values = Array.ConvertAll(inputLine, int.Parse);
        int lengthArray = values.Length;

        int maxSum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            int currentSum = 0;
            currentSum += values[i];

            int currentIndex = i;

            for (int j = 1; j <= jumps; j++)
            {
                int nextIndex = currentIndex + values[currentIndex];
                while (nextIndex > lengthArray - 1)
                {
                    nextIndex = nextIndex - lengthArray;
                }
                currentSum += values[nextIndex];
                currentIndex = nextIndex;
            }
            if (currentSum >= maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}
