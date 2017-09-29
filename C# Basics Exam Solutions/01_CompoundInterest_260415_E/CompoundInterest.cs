using System;
class CompoundInterest
{   
    static void Main()
    {
        decimal p = decimal.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        decimal i = decimal.Parse(Console.ReadLine());
        decimal f = decimal.Parse(Console.ReadLine());

        double bankSum = (double) (1 + i);
        decimal bankInterest = (decimal)Math.Pow(bankSum, n);
        decimal bankLoan = p * bankInterest;

        decimal friendInterest = 1 + f;
        decimal friendLoan = p * friendInterest;

        if (bankLoan < friendLoan)
        {
            Console.WriteLine("{0:F2} Bank", bankLoan);
        }
        else if (friendLoan <= bankLoan)
        {
            Console.WriteLine("{0:F2} Friend", friendLoan);
        }
    }
}
