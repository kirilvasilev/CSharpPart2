//Write a method that checks if the element at given
//position in given array of integers is bigger than its 
//two neighbors (when such exist).

using System;
class ElementBiggerThanNeighbours
{
    static bool isItbigger(int[] arryLenght, int number)
    {
        bool bigger = false;
        if (arryLenght[number] > arryLenght[number + 1] &&
            arryLenght[number] > arryLenght[number - 1])
        {
            bigger = true;
        }
        return bigger;
    }
    static void Main(string[] args)
    {

        int[] arraytotest = {1,5,2,2,2,1,5,3,6,8,7,8,7,7,7,8,9
                                    ,9,0,0,10,10,2,3,2,2,4,1,5,5,8,9,6,3,1,4,5,};
        Console.WriteLine("Enter number to see if its bigger than its neighbours:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(isItbigger(arraytotest, input));
    }
}