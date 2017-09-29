using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        string kindOfYear = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        if (p < 0 || p > 300)
        {
            Console.WriteLine("Wrong input!");
        }
        else if (h < 0 || h > 52)
        {
            Console.WriteLine("Wrong input!");
        }
        else
        {
            double totalPlays = p/2 + h + (52 - h)*2/3;

            if (kindOfYear == "t")
            {
                double totalPlaysRounded = (int) Math.Floor(totalPlays + 3);
                Console.WriteLine(totalPlaysRounded);
            }
            if (kindOfYear == "f")
            {
                double totalPlaysRounded = (int) Math.Floor(totalPlays);
                Console.WriteLine(totalPlaysRounded);
            }
        }
    }
}
