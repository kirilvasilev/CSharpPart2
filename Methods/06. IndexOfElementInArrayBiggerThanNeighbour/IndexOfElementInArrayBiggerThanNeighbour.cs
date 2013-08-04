//Write a method that returns the index of the first
//element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.

using System;
class IndexOfElementInArrayBiggerThanNeighbour
{
    static int isItbigger(int[] arryLenght)
    {
        int position;
        for (int i = 0; i < arryLenght.Length; i++)
        {
            if (arryLenght[i] > arryLenght[i + 1] &&
                arryLenght[i] > arryLenght[i - 1])
            {
                position = i;
                return position;
            }

        }
        return -1;
    }
    static void Main(string[] args)
    {

        int[] arraytotest = {1,5,2,2,2,1,5,3,6,8,7,8,7,7,7,8,9
                                    ,9,0,0,10,10,2,3,2,2,4,1,5,5,8,9,6,3,1,4,5,};

        Console.WriteLine(isItbigger(arraytotest));
    }
}