using System;
class BiggestTriple
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] elements = inputLine.Split(' ');
        
        int[] triples = new int[(elements.Length) / 3];
        int remains = elements.Length%3; 

        int triplesMaxValue = int.MinValue;
        int lastTripleValue = 0;
        int maxValue = 0;

        int firstMaxValue = 0;
        int secondMaxValue = 0;
        int thirdMaxValue = 0;

        for (int i = 0; i < triples.Length * 3; i += 3)
        {
            triples[i / 3] = int.Parse(elements[i]) + int.Parse(elements[i + 1]) + int.Parse(elements[i + 2]);
            if (triples[i / 3] > triplesMaxValue)
            {
                triplesMaxValue = triples[i / 3];
                firstMaxValue = int.Parse(elements[i]);
                secondMaxValue = int.Parse(elements[i+1]);
                thirdMaxValue = int.Parse(elements[i+2]);
            }
        }

        if (remains > 0)
        {
            for (int i = triples.Length*3; i < elements.Length; i++)
            {
                lastTripleValue += int.Parse(elements[i]);
            }
            maxValue = Math.Max(triplesMaxValue, lastTripleValue);

            if (maxValue == triplesMaxValue)
            {
                Console.WriteLine(firstMaxValue + " " + secondMaxValue + " " + thirdMaxValue);
            }
            else if (maxValue == lastTripleValue)
            {
                for (int i = triples.Length*3; i < elements.Length; i++)
                {
                    Console.Write(int.Parse(elements[i]) + " ");
                }
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine(firstMaxValue + " " + secondMaxValue + " " + thirdMaxValue);
        }
    }
}
