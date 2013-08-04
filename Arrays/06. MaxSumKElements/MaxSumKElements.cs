// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaxSumKElements
{
    static void Main()
    {
        //input:K and array length
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Array Length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Element {0}: ", i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;
        //Buuble Sort
        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }         
        }
        //sum the last K elements from the sorted array
        int sum = 0;
        for (int i = arrayLength-k; i <= arrayLength-1; i++)
        {
            sum +=arr[i];
        }
        Console.WriteLine(sum);

    }
}