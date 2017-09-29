using System;
class TravellerBob
{
    static void Main()
    {
        string typeOfYear = Console.ReadLine();
        int c = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        if (typeOfYear == "normal")
        {
            double numberOfTravels = c * 4 * 3 + f * 2 * 2 + (12 - c - f) * 0.6 * 4 * 3;
            int numberOfTravelsRounded = (int)Math.Floor(numberOfTravels);
            Console.WriteLine(numberOfTravelsRounded);
        }
        else if (typeOfYear == "leap")
        {
            double numberOfTravels = (c * 4 * 3 + f * 2 * 2 + (12 - c - f) * 0.6 * 4 * 3) * 1.05;
            int numberOfTravelsRounded = (int)Math.Floor(numberOfTravels);
            Console.WriteLine(numberOfTravelsRounded);
        }
    }
}
