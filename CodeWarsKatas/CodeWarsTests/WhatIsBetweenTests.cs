using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class WhatIsBetweenTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            //Arrange
            WhatIsBetween Test1 = new WhatIsBetween();
            int inputA = 1;
            int inputB = 4;
            int[] expected = { 1, 2, 3, 4 };

            //Act
            int[] result = Test1.Between(inputA, inputB);

            //Assert
            CollectionAssert.AreEqual(expected, result, "method should return an int array of all numbers between the first input int and the second input int (inclusive).");
        }
    }
}
