//Write a program that reads a rectangular matrix of size NxM and
//finds in it the square 3x3 that has maximal sum of its elements

using System;
class MaxSumOfRectangleInMatrix
{
    static void Main()
    {
        int[,] matrix = {
            {7, 1, 3, 3, 2, 1},
            {1, 3, 9, 8, 5, 6},
            {4, 6, 7, 9, 1, 0},
            {7, 1, 3, 3, 2, 1},
            {1, 3, 9, 8, 5, 6},
            {4, 6, 7, 9, 1, 0},
          };

        int area = 3;
        int sum = int.MinValue;
        int maxSum = int.MinValue;
        int startR = 0;
        int startC = 0;

        for (int row = 0; row < matrix.GetLength(0) - area - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - area - 1; col++)
            {
                sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col]
                    + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startC = col;
                    startR = row;
                }
            }
        }
        

        for (int row = startR; row < startR + area; row++)
        {
            for (int col = startC; col < startC + area; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Maximum Sum: {0}",maxSum);
    }
    
}