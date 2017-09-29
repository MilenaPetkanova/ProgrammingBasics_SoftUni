using System;
using System.Text;

class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        if (n >= 3125)
        {
            Console.WriteLine("No");
        }

        int counter = 0;
        StringBuilder sb = new StringBuilder();

        for (int i1 = 0; i1 < input.Length; i1++)
        {
            for (int i2 = 0; i2 < input.Length; i2++)
            {
                for (int i3 = 0; i3 < input.Length; i3++)
                {
                    for (int i4 = 0; i4 < input.Length; i4++)
                    {
                        for (int i5 = 0; i5 < input.Length; i5++)
                        {
                            sb.Append(input[i1]).Append(input[i2]).Append(input[i3]).Append(input[i4]).Append(input[i5]);
                            if (counter == n)
                            {
                                string result = sb.ToString();
                                Console.WriteLine(result);
                                return;
                            }
                            else
                            {
                                counter++;
                                sb.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}
