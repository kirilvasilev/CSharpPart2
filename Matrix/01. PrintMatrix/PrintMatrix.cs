//1. Write a program that fills and prints a matrix of size 
//(n, n) as shown below: (examples for n = 4)

using System;
class PrintMatrix
{
    static void Main()
    {
        Console.Write("Size of Matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int counter = 1;
        int digit = 1;
        // a)
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row,col] = counter;
                counter++;               
            }

        }
        counter = 1;
        Console.WriteLine("a)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[j, i]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        // b)
        bool positionDown = true;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 1)
            {
                positionDown = false;
            }
            else
            {
                positionDown = true;
            }
            if (positionDown)
            {
                for (int row = 0; row < n; row++)
                 {
                      matrix[col,row] = counter;
                      counter++;
                 }
            }
            else
            {
                for (int row = n-1; row >= 0; row--)
                {
                    matrix[col, row] = counter;
                    counter++;
                }
            }

        }
        counter = 1;
        Console.WriteLine("b)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[j, i]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        //c
        int r = n - 1;
        int c = 0;
        int StartRow = n - 1;
        int StartCol = 0;
        matrix[r, c] = 1;

        while (digit < n * n)
        {
            
            if (r == (n - 1) && c < (n - 1))
            {
                StartRow--;
                StartCol = 0;
                r = StartRow;       
                c = StartCol;       
                digit++;
                matrix[r, c] = digit;

                
                while (r < (n - 1) && c < (n - 1))
                {
                    r++;    
                    c++;    
                    digit++;
                    matrix[r, c] = digit;
                }
            }
           
            if (r <= (n - 1) && c == (n - 1))
            {
                StartRow = 0;
                StartCol++;
                r = StartRow;   
                c = StartCol;   
                digit++;        
                matrix[r, c] = digit;

                
                while (c < (n - 1))
                {
                    r++;    
                    c++;    
                    digit++;
                    matrix[r, c] = digit;
                }
            }
        }

        Console.WriteLine("c)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);     
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        //d
        int offset = 0;
        int Row = 0;
        int Col = 0;

        while (digit <= n * n)
        {
            //move down
            for (Row = offset; Row < n - offset; Row++)
            {
                Col = offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            //move right
            for (Col = 1 + offset; Col < n - offset; Col++)
            {
                Row = n - 1 - offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            //move up
            for (Row = n - 2 - offset; Row >= offset; Row--)
            {
                Col = n - 1 - offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            //move left
            for (Col = n - 2 - offset; Col >= offset + 1; Col--)
            {
                Row = offset;
                matrix[Row, Col] = digit;
                digit++;
            }
            offset++;
        }

        Console.WriteLine("d)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);     
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();
    }
   
}
