using System;
class OddOrEvenCounter
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        string[] setNames = {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"};
        
        int setSum = 0;
        int bestSet = 0;

        int currentSum;

        int[,] numbers = new int[n, c];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < c; j++)
            {
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            for (int j = 0; j < c; j++)
            {
                if (s == "odd")
                {
                    if (numbers[i, j]%2 == 1)
                    {
                        currentSum += 1;
                    }
                }
                else
                {
                    if (numbers[i, j] % 2 == 0)
                    {
                        currentSum += 1;
                    }
                }
            }
            if (setSum < currentSum)
            {
                setSum = currentSum;
                bestSet = i;
            }
        }

        if (setSum == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", setNames[bestSet], s, setSum);
        }
        
    }
}
