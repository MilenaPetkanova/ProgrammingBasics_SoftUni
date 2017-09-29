using System;
class PiggyBank
{
    static void Main()
    {
        int priceOfTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int monthlySavings = (30 - partyDays)*2 - partyDays*5;
        if (monthlySavings > 0)
        {
            double mothsToSave = (double)priceOfTank / monthlySavings;
            double years = mothsToSave / 12;
            double months = mothsToSave % 12;

            Console.WriteLine("{0} years, {1} months", (int)Math.Floor(years), (int)Math.Ceiling(months));
        }
        else
        {
            Console.WriteLine("never");
        }
    }
}
