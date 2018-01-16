using System;
using System.Collections.Generic;

namespace ArrayLeftRotation
{
    class Program
    /*
        * Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.
        */
    {
        static void Main(string[] args)
        {
            
            Int32[] originalArry = new Int32[] {1,2,3,4 ,5};
            int numberOfRotation = 2;
            Queue<int> newArray = new Queue<int>(originalArry);

            for (int i = 0; i < numberOfRotation; i++)
            {
                int placeHolder = newArray.Dequeue();
                newArray.Enqueue(placeHolder);
            }
            
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
           

        }
    }
}