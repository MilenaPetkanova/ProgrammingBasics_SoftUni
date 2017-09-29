using System;
class CrossingSequences
{
    static void Main()
    {
        int firstTribN = int.Parse(Console.ReadLine());
        int secondTribN = int.Parse(Console.ReadLine());
        int thirdTribN = int.Parse(Console.ReadLine());
        int spiralStartN = int.Parse(Console.ReadLine());
        int steps = int.Parse(Console.ReadLine());

        int currentTribN = 0;
        int currentSpiralN = spiralStartN;

        if (currentSpiralN == firstTribN || currentSpiralN == secondTribN || currentSpiralN == thirdTribN)
        {
            Console.WriteLine(currentSpiralN);
            return;
        }

        int copyOfFirstTripN = firstTribN;
        int copyOfSecondTripN = secondTribN;
        int copyOfThirdTripN = thirdTribN;
        for (int i = 1; i <= 1000000; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                currentSpiralN += i*steps;

                firstTribN = copyOfFirstTripN;
                secondTribN = copyOfSecondTripN;
                thirdTribN = copyOfThirdTripN;

                while (thirdTribN <= 1000000)
                {
                    if (currentSpiralN == firstTribN || currentSpiralN == secondTribN || currentSpiralN == thirdTribN)
                    {
                        Console.WriteLine(currentSpiralN);
                        return;
                    }
                    currentTribN = firstTribN + secondTribN + thirdTribN;
                    firstTribN = secondTribN;
                    secondTribN = thirdTribN;
                    thirdTribN = currentTribN;
                }
                
                if (currentSpiralN > 1000000)
                {
                    Console.WriteLine("No");
                    return;
                }
            }                
        }
    }
}
