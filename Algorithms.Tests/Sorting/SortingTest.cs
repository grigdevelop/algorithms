using Algorithms.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void InsertionSort()
        {
            int[] array = new int[] { 3, 4, 5, 6, 2 };
            Lib.Sorting.InsertionSort.Sort(array);
            AssertSorting.AssertAscendingOrder(array);
        }

        [TestMethod]
        public void InsertionSortByShift()
        {
            int[] array = new int[] { 3, 4, 5, 6, 2 };
            array = Lib.Sorting.InsertionSort.SortByShift(array);
            AssertSorting.AssertAscendingOrder(array);
        }
    }
}
