using System;
using System.Text;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime endDate = new DateTime(endYear, 12, 31);
        DateTime currDate = new DateTime(startYear, 01, 01);
        int counter = 0;

        while (currDate <= endDate)
        {
            string currDateStr = currDate.ToString("ddMMyyyy");
            int currWeight = 0;
            
            for (int i = 0; i < currDateStr.Length; i++)
            {
                for (int j = i+1; j<currDateStr.Length; j++)
                {
                    int currDigit = (currDateStr[i] - 48) * (currDateStr[j] - 48);
                    currWeight += currDigit;
                }
            }
            
            if (currWeight == magicWeight)
            {
                string output = currDateStr.Insert(2, "-").Insert(5, "-");
                Console.WriteLine(output);
                counter++;
            }
   
            currDate = currDate.AddDays(1);
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}
