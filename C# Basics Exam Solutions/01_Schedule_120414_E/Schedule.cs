using System;
class Schedule
{
    static void Main()
    {
        int startingHour = int.Parse(Console.ReadLine());
        int startingMinutes = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        int mm = startingMinutes + durationMinutes;
        int hh = startingHour + durationHours;

        if (mm >= 60)
        {
            hh += 1;
            mm -= 60;
        }

        if (hh == 12)
        {
            if (partOfTheDay == "AM")
            {
                partOfTheDay = "PM";
            }
            else if (partOfTheDay == "PM")
            {
                partOfTheDay = "AM";
            }
        }
        else if (hh >= 13 && hh <= 23)
        {
            if (partOfTheDay == "AM")
            {
                partOfTheDay = "PM";
            }
            else if (partOfTheDay == "PM")
            {
                partOfTheDay = "AM";
            }
            hh -= 12;
        }
        else if (hh == 24)
        {
            hh -= 12;
        }
        else if (hh >= 25 && hh <= 35)
        {
            hh -= 24;
        }

        Console.WriteLine("{0:00}:{1:00}:{2}", hh, mm, partOfTheDay);
    }
}
