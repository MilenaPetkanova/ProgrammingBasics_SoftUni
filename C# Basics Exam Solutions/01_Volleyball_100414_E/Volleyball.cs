using System;
class Volleyball
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
        else if (h < 0 || h > 48)
        {
            Console.WriteLine("Wrong input!");
        }
        else
        {
            double totalPlays = h + (48 - h) * 3.0 / 4 + 2.0 / 3 * p;

            if (kindOfYear == "normal")
            {
                int totalPlaysRounded = (int) Math.Floor(totalPlays);
                Console.WriteLine(totalPlaysRounded);
            }
            else if (kindOfYear == "leap")
            {
                int totalPlaysRounded = (int) Math.Floor(totalPlays*1.15);
                Console.WriteLine(totalPlaysRounded);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
