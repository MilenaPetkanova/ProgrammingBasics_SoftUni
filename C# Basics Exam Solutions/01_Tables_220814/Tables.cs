using System;
class Tables
{
    static void Main()
    {
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        int p3 = int.Parse(Console.ReadLine());
        int p4 = int.Parse(Console.ReadLine());
        int topsAvailable = int.Parse(Console.ReadLine());
        int tablesNeeded = int.Parse(Console.ReadLine());
     
        int legsAvailable = p1 + p2*2 + p3*3 + p4*4;
        int legsForTables = legsAvailable / 4;

        int tablesMade = Math.Min(topsAvailable, legsForTables);

        if (tablesMade == tablesNeeded)
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }

        if (tablesMade > tablesNeeded)
        {
            int legsLeft = legsAvailable - (4 * tablesNeeded);
            int topsLeft = topsAvailable - tablesNeeded;

            Console.WriteLine("more: {0}", tablesMade - tablesNeeded);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }

        if (tablesMade < tablesNeeded)
        {
            int topsNeeded = tablesNeeded - topsAvailable;
            if (topsNeeded < 0)
            {
                topsNeeded = 0;
            }
            int legsNeeded = (4 * tablesNeeded) - legsAvailable;
            if (legsNeeded < 0)
            {
                legsNeeded = 0;
            }
            Console.WriteLine("less: {0}", tablesMade - tablesNeeded);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
        }
    }    
}

