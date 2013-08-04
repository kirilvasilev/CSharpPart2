//Write a method that reverses the digits of given
//decimal number. Example: 256 ‡ 652

using System;
using System.Text;
class ReverseDigits
{
    static string NumberInReverse(int num)
    {
        StringBuilder reverseNumber = new StringBuilder();
        while (num != 0)
        {
            int lastDigit = num % 10;
            int lastNumber = num / 10;
            num = lastNumber;

            reverseNumber.Append(lastDigit);
        }

        return reverseNumber.ToString();
    }

    static void Main()
    {
        int n = 123;
        Console.WriteLine(NumberInReverse(n));
    }
}