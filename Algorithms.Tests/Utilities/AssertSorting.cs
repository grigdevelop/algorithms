using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Utilities
{
    public static class AssertSorting
    {
        public static void AssertAscendingOrder(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] > inputArray[i + 1])
                {
                    Assert.Fail(i + "th element bigger then next to it.");
                }
            }
        }

        
    }
}
