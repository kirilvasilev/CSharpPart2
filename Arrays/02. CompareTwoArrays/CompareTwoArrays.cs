    using System;
        class CompareTwoArrays
        {
            static void Main()
            {
                Console.Write("Array Lenth: ");
                int arrayLenth = int.Parse(Console.ReadLine());
                int[] arrayOne = new int [arrayLenth];
                int[] arrayTwo = new int[arrayLenth];
                int element = 0;
                for (int i = 0; i < arrayLenth; i++)
                {
                    Console.Write("Element {0} Array One: ", element);
                    arrayOne[i] = int.Parse(Console.ReadLine());
                    Console.Write("Element {0} Array Two: ", element);
                    arrayTwo[i] = int.Parse(Console.ReadLine());
                    element++;
                    if (arrayOne[i] > arrayTwo[i])
                    {
                        Console.WriteLine("{0} > {1}", arrayOne[i], arrayTwo[i]);
                    }
                    else if (arrayOne[i] < arrayTwo[i])
                    {
                        Console.WriteLine("{0} < {1}", arrayOne[i], arrayTwo[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0} = {1}", arrayOne[i], arrayTwo[i]);
                    }
                }
            }
        }