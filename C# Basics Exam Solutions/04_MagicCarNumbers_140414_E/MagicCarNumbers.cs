using System;
class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        int output = 0;

        char[] xy = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        
        int numberWeight = 40;

        for (int x = 0; x < xy.Length; x++)
        {
            numberWeight += (xy[x] - 64)*10;
            for (int y = 0; y < xy.Length; y++)
            {
                numberWeight += (xy[y] - 64)*10;
                
                for (int a = 0; a < 10; a++)
                {
                    int aaaa = 4 * a;
                    if (numberWeight + aaaa == magicWeight)
                    {
                        output++;
                    }
                    for (int b = 0; b < 10; b++)
                    {
                        if (b == a)
                        {
                            continue;
                        }
                        int abbb = a + 3 * b;
                        int aaab = 3 * a + b;
                        int aabbABABabba = a + a + b + b;

                        if (numberWeight + abbb == magicWeight)
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
                numberWeight -= (xy[y] - 64)*10;
            }
            numberWeight -= (xy[x] - 64)*10;
        }
        Console.WriteLine(output);
    }
}
