using System;
class BookProblem
{
    static void Main()
    {
        int numberOfPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int pagesForNormalDay = int.Parse(Console.ReadLine());

        if (numberOfPages > 2000000 && numberOfPages < 0)
        {
            Console.WriteLine("wrong input");
        }
        else if (campingDays > 30 && campingDays < 0)
        {
            Console.WriteLine("wrong input");
        }
        else if (pagesForNormalDay > 100 && pagesForNormalDay < 0)
        {
            Console.WriteLine("wrong input");
        }

        else
        {
            if (30 - campingDays <= 0)
            {
                Console.WriteLine("never");
                return;
            }
            else
            {
                double normalDays = 30 - campingDays;
                double timeToRead = numberOfPages / (normalDays * pagesForNormalDay);

                double years = timeToRead / 12;
                double months = timeToRead % 12;

                Console.WriteLine("{0} years {1} months", (int) Math.Floor(years), (int) Math.Ceiling(months));
                
            }
        }
    }
}
