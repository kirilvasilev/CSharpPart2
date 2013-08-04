//Write a method that returns the last digit of given
//integer as an English word. Examples: 512 ‡ 
//"two", 1024 ‡ "four", 12309 ‡ "nine".

using System;
class LastDigitToEnglish
{
    static string AsString(int position)
    {
        string[] digitStr = { "zero", "One", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        return digitStr[position];

    }
    static void Main(string[] args)
    {

        Console.WriteLine("type a num:");
        int num = int.Parse(Console.ReadLine());
        int toStringIt = num % 10;

        Console.WriteLine("Your number s last digit is : {0}", AsString(toStringIt));


    }
}