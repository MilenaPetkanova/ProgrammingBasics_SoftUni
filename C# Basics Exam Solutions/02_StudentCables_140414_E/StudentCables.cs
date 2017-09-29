using System;
class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int totalLength = 3;

        for (int i = 0; i < n; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string mesure = Console.ReadLine();

            if (cableLength < 20 && mesure == "centimeters")
            {
                continue;
            }
            if (mesure == "meters")
            {
                cableLength *= 100;
            }
            totalLength += cableLength;
            totalLength -= 3;
        }
        
        int cables = totalLength / 504;
        int remaining = totalLength % 504;
        Console.WriteLine(cables);
        Console.WriteLine(remaining);
    }
}

