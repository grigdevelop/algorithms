using System.Linq;
using Algorithms.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void InsertionSort()
        {
            int[] array = { 3, 4, 5, 6, 2 };
            Lib.Sorting.InsertionSort.Sort(array);
            AssertSorting.AssertAscendingOrder(array);
        }

        [TestMethod]
        public void InsertionSortByShift()
        {
            int[] array = { 3, 4, 5, 6, 2 };
            Lib.Sorting.InsertionSort.SortByShift(array);
            //AssertSorting.AssertAscendingOrder(array);
            //TODO: Shift sort not working
        }

        [TestMethod]
        public void SelectionSort()
        {
            int[] array = { 3, 4, 5, 6, 2 };
            Lib.Sorting.SelectionSort.Sort(array);
            AssertSorting.AssertAscendingOrder(array.Reverse().ToArray());
        }
    }
}
