using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class EvenOddsTests
    {
        [TestMethod]
        public void EvenOdds_EvenOrOdd_EvenNumber()
        {
            //Arrange
            EvenOdds Test1 = new EvenOdds();
            int input = 8;
            string expected = "Even";

            //Act
            string result = Test1.EvenOrOdd(input);

            //Assert
            Assert.AreEqual(expected, result, "If number is even method should return 'Even'");
        }

        [TestMethod]
        public void EvenOdds_EvenOrOdd_OddNumber()
        {
            //Arrange
            EvenOdds Test2 = new EvenOdds();
            int input = 31;
            string expected = "Odd";

            //Act
            string result = Test2.EvenOrOdd(input);

            //Assert
            Assert.AreEqual(expected, result, "If number is odd method should return 'Odd'");
        }

        [TestMethod]
        public void EvenOdds_EvenOrOdd_NegativeNumber()
        {
            //Arrange
            EvenOdds Test3 = new EvenOdds();
            int input = -10;
            string expected = "Even";

            //Act
            string result = Test3.EvenOrOdd(input);

            //Assert
            Assert.AreEqual(expected, result, "If number is even method should return 'Even'");
        }

    }
}
