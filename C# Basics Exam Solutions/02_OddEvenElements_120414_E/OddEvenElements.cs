using System;
class OddEvenElements
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');
        if (inputLine[0] == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }

        decimal[] numbers = Array.ConvertAll(inputLine, decimal.Parse);

        decimal oddSum = 0;
        decimal evenSum = 0;
        decimal oddMax = -1000001;
        decimal evenMax = -1000001;
        decimal oddMin = 1000001;
        decimal evenMin = 1000001;

        int n = 0;

        bool odd = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            decimal element = numbers[i];
            n++;

            if (odd)
            {
                oddSum += element;
                if (oddMax < element)
                {
                    oddMax = element;
                }
                if (oddMin > element)
                {
                    oddMin = element;
                }
            }
            else
            {
                evenSum += element;
                if (evenMax < element)
                {
                    evenMax = element;
                }
                if (evenMin > element)
                {
                    evenMin = element;
                }
            }
            odd = !odd;
        }

        if (n == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", 
                oddSum.ToString("0.###"), oddMin.ToString("0.###"), oddMax.ToString("0.###"));
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                oddSum.ToString("0.###"), oddMin.ToString("0.###"), oddMax.ToString("0.###"), 
                evenSum.ToString("0.###"), evenMin.ToString("0.###"), evenMax.ToString("0.###"));
        }

    }
}
