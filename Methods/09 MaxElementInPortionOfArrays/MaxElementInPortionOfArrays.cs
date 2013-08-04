//Write a method that return the maximal element
//in a portion of array of integers starting at given 
//index. Using it write another method that sorts an 
//array in ascending / descending order.

using System;
class MaxElementInPortionOfArrays
{
    static int FindBiggestNumFromGivenIndex(int[] array, int index)
    {
        int length = array.Length;
        int biggest = 0;
        for (int i = index; i < length; i++)
        {
            if (array[i] > biggest)
            {
                biggest = array[i];
            }
        }
        return biggest;
    }
    static int[] SAsAss(int[] arr)
    {
        Array.Sort(arr);
        return arr;
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
    static void PrintArrayReverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] array = {1,5,2,2,2,1,5,3,6,8,7,8,7,7,7,8,9
                                    ,9,0,0,10,10,2,3,2,2,4,1,5,5,8,9,6,3,1,4,5,};
        int index = 2;

        Console.WriteLine(FindBiggestNumFromGivenIndex(array, index));
        PrintArray(SAsAss(array));
        PrintArrayReverse(array);
    }
}