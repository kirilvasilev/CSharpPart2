//Write a program to calculate n! for each n in the
//range [1..100]. Hint: Implement first a method 
//that multiplies a number represented as array of 
//digits by given integer number.

using System;
using System.Collections.Generic;
class CalculateN
{
    static void Main()
    {

        List<int> fact = new List<int>();
        fact.Add(1);
        for (int i = 2; i < 100; i++)
        {
            CalcFactorial(fact, i);
            Print(fact);
        }


    }

    private static void Print(List<int> fact)
    {
        for (int i = fact.Count - 1; i >= 0; i--)
        {
            Console.Write(fact[i]);
        }
        Console.WriteLine();
    }

    private static void CalcFactorial(List<int> fact, int n)
    {
        List<int> factCopy = new List<int>();
        for (int i = 0; i < fact.Count; i++)
        {
            factCopy.Add(fact[i]);
        }

        int carryTens;
        int carryHundreds;
        int result;

        for (int i = factCopy.Count - 1; i >= 0; i--)
        {
            result = 0;
            carryTens = 0;
            carryHundreds = 0;
            result = factCopy[i] * n;
            fact[i] = result % 10;


            if (result > 99)
            {
                carryHundreds = result / 100;
                carryTens = (result / 10) % 10;
            }
            else if (result > 9)
            {
                carryTens = result / 10;
            }

            if (carryTens > 0)
            {
                if (fact.Count < i + 2)
                {
                    fact.Add(carryTens);
                }
                else
                {
                    fact[i + 1] += carryTens;
                    if (fact[i + 1] > 9)
                    {
                        fact[i + 1] %= 10;
                        carryHundreds++;
                    }

                }
            }
            if (carryHundreds > 0)
            {
                if (fact.Count < i + 3)
                {
                    fact.Add(carryHundreds);
                }
                else
                {
                    fact[i + 2] += carryHundreds;
                }


            }

        }


    }
}