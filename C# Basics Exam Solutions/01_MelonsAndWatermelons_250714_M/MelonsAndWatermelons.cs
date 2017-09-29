using System;
class MelonsAndWatermelons
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int watermelons = 0;
        int melons = 0;
        int dayOfWeek;

        for (int i = s; i < s + d; i++)
        {
            dayOfWeek = i;
            if (dayOfWeek > 7)
            {
                dayOfWeek = dayOfWeek % 7;
            }

            if (dayOfWeek == 1)
            {
                watermelons += 1;
            }
            if (dayOfWeek == 2)
            {
                melons += 2;
            }
            if (dayOfWeek == 3)
            {
                watermelons += 1;
                melons += 1;
            }
            if (dayOfWeek == 4)
            {
                watermelons += 2;
            }
            if (dayOfWeek == 5)
            {
                watermelons += 2;
                melons += 2;
            }
            if (dayOfWeek == 6)
            {
                watermelons += 1;
                melons += 2;
            }
        }

        if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons", watermelons-melons);
        }
        if (watermelons < melons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
        if (watermelons == melons)
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
    }
}
