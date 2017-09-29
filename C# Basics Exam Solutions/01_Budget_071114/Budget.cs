using System;
class Budget
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        if (p > 22)
        {
            Console.WriteLine("Wrong inpput.");
        }
        else if (h > 4)
        {
            Console.WriteLine("Wrong inpput.");
        }
        else if (n < 0 || p < 0 || h < 0)
        {
            Console.WriteLine("Wrong inpput.");
        }
        else
        {
            double a = 0.03 * n;
            int b = (int)Math.Floor(a);

            double leftover = n - 150 - p*b - 22*10 - (4-h)*40;

            if (leftover == 0)
            {
                Console.WriteLine("Exact Budget.");
            }
            else if (leftover > 0)
            {
                Console.WriteLine("Yes, leftover {0}.", leftover);
            }
            else 
            {
                Console.WriteLine("No, not enough {0}.", -leftover);
            }
        }
    }
}
