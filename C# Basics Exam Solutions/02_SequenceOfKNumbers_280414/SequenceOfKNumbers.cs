using System;
class SequenceOfKNumbers
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
        
        string[] input = inputLine.Split(' ');
        int[] elements = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            elements[i] = int.Parse(input[i]);
        }

        int number;
        
        for (int i = 0; i < elements.Length - k; i++)  
        {
            number = 0;
         
            for (int j = i; j < i + k; j++)
            {
                number += elements[j];
            }
            
            if (number / k == elements[i] && number % k == 0)
            {
                i += k-1;
            }
            else
            {
                Console.Write(elements[i] + " ");
            }
        }

        for (int i = elements.Length - k; i < elements.Length; i++)
        {
            number = 0;

            for (int j = i; j < elements.Length; j++)
            {
                number += elements[j];
            }

            if (number / k == elements[i] && number % k == 0)
            {
                break;
            }
            else
            {
                Console.Write(elements[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
