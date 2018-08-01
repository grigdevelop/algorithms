﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Lib.Sorting
{
    public class InsertionSort
    {
        public static int[] Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        var temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }

            return inputArray;
        }

        public static int[] SortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;
            }
            return inputArray;
        }
    }
}
