using System;
class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();
        
        int apartments = floors*flats;
        string hours = "";
        int j = 4;

        double[] e1 = {100.53+8*125.9, 0, 2*100.53+2*125.9, 7*100.53+6*125.9};
        double[] ed = { apartments * e1[0], 0, apartments * e1[2], apartments * e1[3] };

        for (int i = 0; i <= 1; i++)
        {
            if (time[i] >= '0' && time[i] <= '9')
            {
                hours = hours + time[i];
            }
        }

        int hour = int.Parse(hours);

        if (hour >= 0 && hour <= 8)
        {
            j = 0;
        }
        if (hour >= 9 && hour <= 13)
        {
            j = 1;
        }
        if (hour >= 14 && hour <= 18)
        {
            j = 2;
        }
        if (hour >= 19 && hour <= 23)
        {
            j = 3;
        }

        if (j >= 0 && j <= 3)
        {
            int edR = (int) Math.Floor(ed[j]);
            Console.WriteLine(edR + " " + "Watts");
        }
    }
}
