using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Mathematical
{
    [TestClass]
    public class EasyMathTests
    {
        #region Tests

        [TestMethod]
        public void GreatestCommonDividerTest()
        {
            int result = GreatestCommonDivider(10, 5);
            Assert.AreEqual(5, result);

            result = GreatestCommonDivider(12, 10);
            Assert.AreEqual(2, result);

            result = GreatestCommonDivider(23, 10);
            Assert.AreEqual(1, result);

            result = GreatestCommonDivider(25, 100);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void SquareRootOfNumberTest()
        {
            int result = SquareRootOfNumber(16);
            Assert.AreEqual(4, result);

            result = SquareRootOfNumber(4);
            Assert.AreEqual(2, result);

            result = SquareRootOfNumber(3);
            Assert.AreEqual(-1, result);

            result = SquareRootOfNumber(9);
            Assert.AreEqual(3, result);
        }

        #endregion


        #region Solutions


        private int GreatestCommonDivider(int a, int b)
        {
            while (a!=0 && b!= 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }

            return a + b;
        }

        private int SquareRootOfNumber(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;

            for (int i = 2; i <= number/2; i++)
            {
                if (number / i == i)
                    return i;
            }

            return -1;
        }

        #endregion
    }
}
