using System;
class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        int output = 0;
        
        int numberWeight = 0;

        for (int a = 0; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                if (b == a)
                {
                    continue;
                }
                int aaaa = 4 * a;
                int abbb = a + 3 * b;
                int aaab = 3 * a + b;
                int aabbABABabba = a + a + b + b;

                if (numberWeight + aaaa == magicWeight)
                {
                    output++;
                }
                else if (numberWeight + abbb == magicWeight)
                {
                    output++;
                }
                else if (numberWeight + aaab == magicWeight)
                {
                    output++;
                }
                else if (numberWeight + aabbABABabba == magicWeight)
                {
                    output += 3;
                }
            }
        }
        Console.WriteLine(output);
    }
}
