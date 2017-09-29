using System;
using System.Text;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int counter = 0;
        StringBuilder sb = new StringBuilder();

        for (int i1 = 1; i1 <= 7; i1++)
        {
            for (int i2 = 1; i2 <= 7; i2++)
            {
                for (int i3 = 1; i3 <= 7; i3++)
                {
                    for (int i4 = 1; i4 <= 7; i4++)
                    {
                        for (int i5 = 1; i5 <= 7; i5++)
                        {
                            for (int i6 = 1; i6 <= 7; i6++)
                            {
                                for (int i7 = 1; i7 <= 7; i7++)
                                {
                                    for (int i8 = 1; i8 <= 7; i8++)
                                    {
                                        for (int i9 = 1; i9 <= 7; i9++)
                                        {
                                            if (i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 == sum &&
                                                (i7 * 100 + i8 * 10 + i9) - (i4 * 100 + i5 * 10 + i6) == diff &&
                                                (i4 * 100 + i5 * 10 + i6) - (i1 * 100 + i2 * 10 + i3) == diff)
                                            {
                                                sb.Append(i1).Append(i2).Append(i3).Append(i4).Append(i5).Append(i6).Append(i7).Append(i8).Append(i9);
                                                Console.WriteLine(sb.ToString());
                                                sb.Clear();
                                                counter++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}
