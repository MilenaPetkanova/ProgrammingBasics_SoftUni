using System;
using System.Numerics;
class PeterGame
{
    static void Main()
    {
        ulong startingNum = ulong.Parse(Console.ReadLine());
        ulong endNum = ulong.Parse(Console.ReadLine());
        string replacementString = Console.ReadLine();

        BigInteger sum = 0;

        for (ulong i = startingNum; i < endNum; i++)
        {
            if (i%5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i%5;
            }
        }

        string sumAsString = Convert.ToString(sum);
        string digitToReplace;

        if (sum%2 == 0)
        {
            digitToReplace = sumAsString[0].ToString();
        }
        else
        {
            digitToReplace = sumAsString[sumAsString.Length - 1].ToString();
        }

        sumAsString = sumAsString.Replace(digitToReplace, replacementString);
        Console.WriteLine(sumAsString);
    }
}
