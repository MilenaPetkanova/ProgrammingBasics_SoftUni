using System;
class BookOrders
{
    static void Main()
    {
        int orders = int.Parse(Console.ReadLine());

        int allBooks = 0;
        double allBooksPrice = 0.00;

        for (int i = 0; i < orders; i++)
        {
            int numberOfPacets = int.Parse(Console.ReadLine());
            int booksPerPacet = int.Parse(Console.ReadLine());
            double pricePerBook = double.Parse(Console.ReadLine());

            int booksInOrder = numberOfPacets*booksPerPacet;
            allBooks += booksInOrder;

            double discount = 0;

            if (numberOfPacets >= 10 && numberOfPacets <= 19)
            {
                discount = 0.05;
            }
            else if (numberOfPacets >= 20 && numberOfPacets <= 29)
            {
                discount = 0.06;
            }
            else if (numberOfPacets >= 30 && numberOfPacets <= 39)
            {
                discount = 0.07;
            }
            else if (numberOfPacets >= 40 && numberOfPacets <= 49)
            {
                discount = 0.08;
            }
            else if (numberOfPacets >= 50 && numberOfPacets <= 59)
            {
                discount = 0.09;
            }
            else if (numberOfPacets >= 60 && numberOfPacets <= 69)
            {
                discount = 0.10;
            }
            else if (numberOfPacets >= 70 && numberOfPacets <= 79)
            {
                discount = 0.11;
            }
            else if (numberOfPacets >= 80 && numberOfPacets <= 89)
            {
                discount = 0.12;
            }
            else if (numberOfPacets >= 90 && numberOfPacets <= 99)
            {
                discount = 0.13;
            }
            else if (numberOfPacets >= 100 && numberOfPacets <= 109)
            {
                discount = 0.14;
            }
            else if (numberOfPacets >= 110)
            {
                discount = 0.15;
            }

            allBooksPrice += booksInOrder*pricePerBook*(1 - discount);
        }
        Console.WriteLine(allBooks);
        Console.WriteLine("{0:F2}", allBooksPrice);
    }
}
