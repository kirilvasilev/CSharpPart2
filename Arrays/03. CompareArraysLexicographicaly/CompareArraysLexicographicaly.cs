using System;
class CompareArraysLexicographicaly
{
    static void Main()
    {
        Console.Write("Array One: ");
        string arrayContentOne = Console.ReadLine();
        Console.Write("Array Two: ");
        string arrayContentTwo = Console.ReadLine();
        char[] arrayOne = new char[arrayContentOne.Length];
        char[] arrayTwo = new char[arrayContentTwo.Length];
        
        arrayOne = arrayContentOne.ToCharArray();
        arrayTwo = arrayContentTwo.ToCharArray();

        int loopLenth;
        if (arrayOne.Length<arrayTwo.Length)
        {
            loopLenth = arrayOne.Length;  
        }
        else
        {
            loopLenth = arrayTwo.Length; 
        }
        
        for (int i = 0; i < loopLenth; i++)
        {
            if (arrayOne[i]== arrayTwo[i])
            {
                Console.WriteLine("{0}={1}",arrayOne[i],arrayTwo[i]);
            }
            else
            {
                Console.WriteLine("{0}=!{1}", arrayOne[i], arrayTwo[i]);
            }
        }
    }
}