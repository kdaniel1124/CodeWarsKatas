using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class FindTheOddIntTests
    {
        [TestMethod]
        public void FindTheOddInt_FindOdd_OnlyOdd()
        {
            //Arrange
            FindTheOddInt Test1 = new FindTheOddInt();
            int[] input = { 15 };
            int expected = 15;

            //Act
            int result = Test1.FindOdd(input);

            //Assert
            Assert.AreEqual(expected, result, "");
        }

        [TestMethod]
        public void FindTheOddInt_FindOdd_OnlyEvens()
        {
            //Arrange
            FindTheOddInt Test2 = new FindTheOddInt();
            int[] input = { 15, 30, 45, 60, 60, 45, 30, 15 };
            int expected = 0;

            //Act
            int result = Test2.FindOdd(input);

            //Assert
            Assert.AreEqual(expected, result, "");
        }

        [TestMethod]
        public void FindTheOddInt_FindOdd_OneOddAtEnd()
        {
            //Arrange
            FindTheOddInt Test3 = new FindTheOddInt();
            int[] input = { 1, 2, 3, 1, 2, 3, 4 };
            int expected = 4;

            //Act
            int result = Test3.FindOdd(input);

            //Assert
            Assert.AreEqual(expected, result, "");
        }

    }
}
