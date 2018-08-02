using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sorting
{
    public class SelectionSort
    {

        public static void Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                int maxIndex = i;
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[maxIndex] < inputArray[j])
                    {
                        maxIndex = j;
                    }
                }

                var temp = inputArray[i];
                inputArray[i] = inputArray[maxIndex];
                inputArray[maxIndex] = temp;

            }
        }
    }
}
