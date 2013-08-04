//Write a program that finds the maximal sequence of equal elements in an array.


using System;

public class MaxSequenceInArray
{
    public static void Main()
    {
       
        Console.Write("Array: ");
        string arrayContent = Console.ReadLine();
        char[] array = new char[arrayContent.Length];
        array = arrayContent.ToCharArray();

        int counter = 1;
        int maxCounter = 0;
        string sequence = string.Empty;
        string bestSequence = string.Empty;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
                sequence = array[i].ToString();
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                bestSequence = sequence;
            }

            if (array[i] != array[i + 1])
            {
                
                counter = 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Length of best sequence: {0}", maxCounter);
        Console.Write("{");
        for (int i = 0; i < maxCounter; i++)
        {
            if (i == maxCounter - 1)
                Console.Write(bestSequence);
            else
                Console.Write(bestSequence + ",");
        }
        Console.WriteLine("}");

        
    }
}