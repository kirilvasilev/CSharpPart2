//Write a method GetMax() with two parameters that
//returns the bigger of two integers. Write a program 
//that reads 3 integers from the console and prints 
//the biggest of them using the method GetMax().

using System;
class GetMaxMethod
{
    static int Maxvalue(int num1, int num2)
    {
        int best = num2;
        if (num1 > num2)
        {
            best = num1;

        }
        else
            best = num2;
        return best;
    }
    static void Main(string[] args)
    {
        int firstnum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int biggerFor1stHalf = Maxvalue(firstnum, secondNum);
        Console.WriteLine("Biggest is {0} , Enter 3 th num to see if its bigger:", biggerFor1stHalf);
        int thirdnum = int.Parse(Console.ReadLine());
        int biggestofAll = Maxvalue(biggerFor1stHalf, thirdnum); Console.WriteLine("The biggest of all is {0}", biggestofAll);




    }
}