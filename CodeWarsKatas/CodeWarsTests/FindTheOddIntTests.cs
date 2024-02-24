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
    }
}
