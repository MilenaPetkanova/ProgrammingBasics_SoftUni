using System;
using System.Text;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int counter = 0;
        StringBuilder sb = new StringBuilder();

        for (int i1 = 5; i1 <= 9; i1++)
        {
            for (int i2 = 5; i2 <= 9; i2++)
            {
                for (int i3 = 5; i3 <= 9; i3++)
                {
                    for (int i4 = 5; i4 <= 9; i4++)
                    {
                        for (int i5 = 5; i5 <= 9; i5++)
                        {
                            for (int i6 = 5; i6 <= 9; i6++)
                            {
                                for (int i7 = 5; i7 <= 9; i7++)
                                {
                                    for (int i8 = 5; i8 <= 9; i8++)
                                    {
                                        for (int i9 = 5; i9 <= 9; i9++)
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
