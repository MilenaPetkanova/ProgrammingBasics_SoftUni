using System;
class Cinema
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int numberOfRows = int.Parse(Console.ReadLine());
        int numberOfColumns = int.Parse(Console.ReadLine());
 
        if (projectionType == "Premiere")
        {
            decimal income = (decimal)12.00 * numberOfRows * numberOfColumns;
            Console.WriteLine("{0:F2} leva", income);
        }
        else if (projectionType == "Normal")
        {
            decimal income = (decimal)7.5 * numberOfRows * numberOfColumns;
            Console.WriteLine("{0:F2} leva", income);
        }
        else if (projectionType == "Discount")
        {
            decimal income = (decimal)5 * numberOfRows * numberOfColumns;
            Console.WriteLine("{0:F2} leva", income);
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
    }
}

