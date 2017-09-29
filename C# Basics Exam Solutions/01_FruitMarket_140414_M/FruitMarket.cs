using System;
class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        double quantity1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        double bananaP = 1.80;
        double cucumberP = 2.75;
        double tomatoP = 3.20;
        double orangeP = 1.60;
        double appleP = 0.86;

        double totalPrice = 0;

        if (dayOfWeek == "Friday")
        {
            bananaP *= 0.90;
            cucumberP *= 0.90;
            tomatoP *= 0.90;
            orangeP *= 0.90;
            appleP *= 0.90;
        }
        if (dayOfWeek == "Sunday")
        {
            bananaP *= 0.95;
            cucumberP *= 0.95;
            tomatoP *= 0.95;
            orangeP *= 0.95;
            appleP *= 0.95;
        }
        if (dayOfWeek == "Tuesday")
        {
            bananaP *= 0.80;
            orangeP *= 0.80;
            appleP *= 0.80;
        }
        if (dayOfWeek == "Wednesday")
        {
            cucumberP *= 0.90;
            tomatoP *= 0.90;
        }
        if (dayOfWeek == "Thursday")
        {
            bananaP *= 0.70;
        }

        if (product1 == "banana")
        {
            totalPrice += bananaP * quantity1;
        }
        if (product2 == "banana")
        {
            totalPrice += bananaP * quantity2;
        }
        if (product3 == "banana")
        {
            totalPrice += bananaP * quantity3;
        }
        if (product1 == "cucumber")
        {
            totalPrice += cucumberP * quantity1;
        }
        if (product2 == "cucumber")
        {
            totalPrice += cucumberP * quantity2;
        }
        if (product3 == "cucumber")
        {
            totalPrice += cucumberP * quantity3;
        }
        if (product1 == "tomato")
        {
            totalPrice += tomatoP * quantity1;
        }
        if (product2 == "tomato")
        {
            totalPrice += tomatoP * quantity2;
        }
        if (product3 == "tomato")
        {
            totalPrice += tomatoP * quantity3;
        }
        if (product1 == "orange")
        {
            totalPrice += orangeP * quantity1;
        }
        if (product2 == "orange")
        {
            totalPrice += orangeP * quantity2;
        }
        if (product3 == "orange")
        {
            totalPrice += orangeP * quantity3;
        }
        if (product1 == "apple")
        {
            totalPrice += appleP * quantity1;
        }
        if (product2 == "apple")
        {
            totalPrice += appleP * quantity2;
        }
        if (product3 == "apple")
        {
            totalPrice += appleP * quantity3;
        }

        Console.WriteLine("{0:F2}", totalPrice);
    }
}
