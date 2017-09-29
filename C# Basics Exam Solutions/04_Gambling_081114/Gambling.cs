using System;

class Gambling
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();
        string[] houseHand = inputLine.Split(' ');
        
        for (int i = 0; i < houseHand.Length; i++)
        {
            if (houseHand[i] == "J" || houseHand[i] == "Q" || houseHand[i] == "K" || houseHand[i] == "A")
            {
                houseHand[i] = houseHand[i].Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14");    
            }
        }

        int houseStrength = Convert.ToInt32(houseHand[0]) + Convert.ToInt32(houseHand[1]) + Convert.ToInt32(houseHand[2]) + Convert.ToInt32(houseHand[3]);

        double allPossibleHands = 0;
        double winningHands = 0;
        for (int i1 = 2; i1 <= 14; i1++)
        {
            for (int i2 = 2; i2 <= 14; i2++)
            {
                for (int i3 = 2; i3 <= 14; i3++)
                {
                    for (int i4 = 2; i4 <= 14; i4++)
                    {
                        allPossibleHands++;
                        int currentHand = i1 + i2 + i3 + i4;
                        if (currentHand > houseStrength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        double probabilityToBeat = winningHands/allPossibleHands;

        if (probabilityToBeat < 0.50)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:F2}", cash*2*probabilityToBeat);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:F2}", cash * 2 * probabilityToBeat);
        }
    }
}
