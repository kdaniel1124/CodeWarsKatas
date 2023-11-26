using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class TotalAmountOfPointsTests
    {
        [TestMethod]
        public void TotalAmountOfPoints_TotalPoints_AllLosses()
        {
            //Arrange
            TotalAmountOfPoints Test1 = new TotalAmountOfPoints();
            string[] input = { "1:2", "0:4", "1:4", "2:3", "0:4"};
            int expected = 0;

            //Act
            int result = Test1.TotalPoints(input);

            //Assert
            Assert.AreEqual(expected, result, "A match should only add to the teams championship score if they won, or tied.");
        }

        [TestMethod]
        public void TotalAmountOfPoints_TotalPoints_HealthyMix()
        {
            //Arrange
            TotalAmountOfPoints Test2 = new TotalAmountOfPoints();
            string[] input = { "1:2", "4:4", "4:1", "2:2", "3:4"};
            int expected = 5;

            //Act
            int result = Test2.TotalPoints(input);

            //Assert
            Assert.AreEqual(expected, result, "For each (wink wink) match in the championship, if our team won we get 3 points, 1 point for a tie, and 0 points for a loss.");
        }

        [TestMethod]
        public void TotalAmountOfPoints_TotalPoints_SuccessfulChampionship()
        {
            //Arrange
            TotalAmountOfPoints Test1 = new TotalAmountOfPoints();
            string[] input = { "4:0", "2:0", "3:1", "3:0", "4:4"};
            int expected = 13;

            //Act
            int result = Test1.TotalPoints(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should add up the total championship score from each match of the series.");
        }

    }
}
