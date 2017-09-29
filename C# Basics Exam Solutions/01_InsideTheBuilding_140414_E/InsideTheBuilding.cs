using System;
using System.Globalization;

class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        int k = 5;

        int[] arrayX = new int[k];
        int[] arrayY = new int[k];
        string[] result = new string[k];

        for (int i = 0; i < k; i++)
        {
            arrayX[i] = int.Parse(Console.ReadLine());
            arrayY[i] = int.Parse(Console.ReadLine());

            if ((arrayX[i] >= 0 && arrayX[i] <= 3 * h && arrayY[i] >= 0 && arrayY[i] <= h) || 
                (arrayX[i] >= h && arrayX[i] <= 2 * h && arrayY[i] >= h && arrayY[i] <= 4 * h))
            {
                result[i] = "inside";
            }
            else
            {
                result[i] = "outside";
            }
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(result[i]);
        }

    }
}
