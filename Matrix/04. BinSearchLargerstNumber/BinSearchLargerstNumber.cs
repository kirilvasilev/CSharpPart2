using System;
class BinSearchLargerstNumber
{
    static void Main()
    {
        Console.Write("Array length:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        Console.WriteLine("Array values:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("K:");
        int k = int.Parse(Console.ReadLine());


        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, k);

        if (numbers[0] > k)
        {
            Console.WriteLine("Number not found");
        }
        else
        {
            if (index >= 0)
            {
                Console.WriteLine("Biggest number <=K: {0}", numbers[index]);
            }
            else
            {
                Console.WriteLine("Biggest number <=K: {0}", numbers[-index - 2]);
            }
        }      
    }
}