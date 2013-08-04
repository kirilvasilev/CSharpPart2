// Write a program that finds the maximal increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaxIncreasingSequenceInArray
{
    static void Main()
    {
        Console.Write("Array: ");
        string arrayContent = Console.ReadLine();
        char[] array = new char[arrayContent.Length];
        array = arrayContent.ToCharArray();

        int counter = 1;
        int maxSequence = 1;
        int sequencesWithMaxLength = 0;
        for (int i = 1; i < arrayContent.Length; i++)
        {
            if (array[i] == array[i - 1] + 1)
            {
                counter++;
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    sequencesWithMaxLength = 1;
                }
                else if (counter == maxSequence)
                {
                    sequencesWithMaxLength++;
                }
            }
            else
            {
                counter = 1;
            }
        }


        if (arrayContent.Length == 0)
        {
            Console.WriteLine("0");
        }
        else if (arrayContent.Length == 1)
        {
           
            Console.WriteLine("{0}", array[0]);
        }
        else
        {
            counter = 1;
            for (int i = 1; i < arrayContent.Length; i++)
            {
                if (array[i] == array[i - 1] + 1)
                {
                    counter++;
                    if (counter == maxSequence)
                    {
                        Console.Write("{ ");
                        for (int j = 1; j <= maxSequence; j++)
                        {
                            if (j < maxSequence)
                            {
                                Console.Write("{0}, ", array[i - maxSequence + j]);
                            }
                            else
                            {
                                Console.Write("{0} ", array[i - maxSequence + j]);
                            }
                        }
                        Console.WriteLine("}");
                       
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
    }
}