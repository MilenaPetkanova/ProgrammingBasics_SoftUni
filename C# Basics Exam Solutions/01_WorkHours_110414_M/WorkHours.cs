using System;
class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        double workHours = 0.9*d*12*p/100;
        int workHoursRounded = (int) Math.Floor(workHours);

        if (workHoursRounded >= h)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(workHoursRounded - h);
        }
        else if (workHoursRounded < h)
        {
            Console.WriteLine("No");
            Console.WriteLine(workHoursRounded - h);
        }
    }
}
