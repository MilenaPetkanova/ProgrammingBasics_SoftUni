using System;
using System.Reflection;

class Airlines
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        string[] secondLine = Console.ReadLine().Split();
        string[] thirdLine = Console.ReadLine().Split();

        int firstClassIncome = Convert.ToInt32(firstLine[0]) * 7000;
        firstClassIncome -= (int)(Convert.ToInt32(firstLine[1]) * (0.7 * 7000));
        firstClassIncome += (int)(Convert.ToInt32(firstLine[2]) * (0.005 * 7000));

        int secondClassIncome = Convert.ToInt32(secondLine[0]) * 3500;
        secondClassIncome -= (int)(Convert.ToInt32(secondLine[1]) * (0.7 * 3500));
        secondClassIncome += (int)(Convert.ToInt32(secondLine[2]) * (0.005 * 3500));

        int thirdClassIncome = Convert.ToInt32(thirdLine[0]) * 1000;
        thirdClassIncome -= (int)(Convert.ToInt32(thirdLine[1]) * (0.7 * 1000));
        thirdClassIncome += (int)(Convert.ToInt32(thirdLine[2]) * (0.005 * 1000));

        int totalIncome = firstClassIncome + secondClassIncome + thirdClassIncome;
        int maxIncome = (int)Math.Round(12*7000*1.005 + 28*3500*1.005 + 50*1000*1.005);

        Console.WriteLine(totalIncome);
        Console.WriteLine(maxIncome - totalIncome);
    }
}
