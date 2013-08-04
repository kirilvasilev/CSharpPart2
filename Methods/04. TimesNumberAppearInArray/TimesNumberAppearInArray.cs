//Write a method that counts how many times
//given number appears in given array. Write a 
//test program to check if the method is working 
//correctly.

using System;
class TimesNumberAppearInArray
{
    static int HowMany(int[] arryLenght, int number)
    {
        int counter = 0;
        for (int i = 0; i < arryLenght.Length; i++)
        {
            if (number == arryLenght[i])
            {
                counter++;
            }

        }
        return counter;
    }
    static void Main(string[] args)
    {

        int[] arraytotest = {1,5,2,2,2,1,5,3,6,8,7,8,7,7,7,8,9
                                    ,9,0,0,10,10,2,3,2,2,4,1,5,5,8,9,6,3,1,4,5,};
        Console.WriteLine("Enter number to see how many times it is used in my array :D(so usefull):");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(HowMany(arraytotest, input));
    }
}