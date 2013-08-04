//Write a program that can solve these tasks:
//­ Reverses the digits of a number
//­ Calculates the average of a sequence of integers
//­ Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to 
//choose which task to solve.
//Validate the input data:
//­ The decimal number should be non-negative
//­ The sequence should not be empty
//­ a should not be equal to 0

using System;
class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("how many integers?");

        int[] arr = { 2, 3, 5, 123, 1, 2, 3, 51, 213 };


        Console.WriteLine("the minimum is {0}", MinimumValue(arr));
        Console.WriteLine("the maxmimum is {0}", MaximumValue(arr));
        Console.WriteLine("the average number is {0}", AverageValue(arr));
        Console.WriteLine("the sum is {0}", Sum(arr));
        Console.WriteLine("the product is {0}", Product(arr));
    }

    static int MinimumValue(int[] arr)
    {

        int minimum = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minimum)
            {
                minimum = arr[i];
            }
        }
        return minimum;
    }

    static int MaximumValue(int[] arr)
    {

        int maxmimum = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxmimum)
            {
                maxmimum = arr[i];
            }
        }
        return maxmimum;
    }

    static double AverageValue(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / 2;
    }

    static long Sum(int[] arr)
    {
        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static long Product(int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}