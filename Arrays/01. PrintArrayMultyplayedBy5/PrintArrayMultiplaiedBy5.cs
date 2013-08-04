using System;
class PrintArrayMultiplaiedBy5
{
    static void Main()
    {
        int[] array = new int[20];

        for (int i = 0; i < array.Length-1; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}