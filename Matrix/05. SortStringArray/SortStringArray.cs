//5. You are given an array of strings. Write a method 
//that sorts the array by the length of its elements 
//(the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;

class SortStringArray
{
    static void Main()
    {
        string[] arr = new string[] { "aaa", "a", "aa", "aaaaa", "aaaa", "aaaaaa", "aaaaaaaaa", "aaaaaaaaaaaaaa", "aaaaaa" };
        Array.Sort(arr, (a, b) => (b.Length).CompareTo(a.Length));
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
      
    }
}