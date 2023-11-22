using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class HighestRankNumberTests
    {
        [TestMethod]
        public void HighestRankNumber_HighestRank_ClearWinner()
        {
            //Arrange
            HighestRankNumber Test1 = new HighestRankNumber();
            int[] input = { 1, 2, 1, 1, 1, 1, 1 };
            int expected = 1;

            //Act
            int result = Test1.HighestRank(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return whichever number occurs the most times, not the amount of times it occurs");
        }

        [TestMethod]
        public void HighestRankNumber_HighestRank_TieBreaker()
        {
            //Arrange
            HighestRankNumber Test2 = new HighestRankNumber();
            int[] input = { 1, 10, 1, 10, 1, 10 };
            int expected = 10;

            //Act
            int result = Test2.HighestRank(input);

            //Assert
            Assert.AreEqual(expected, result, "If two numbers occur the same amount of times, then the larger number should be returned");
        }

        [TestMethod]
        public void HighestRankNumber_HighestRank_NegativeArray()
        {
            //Arrange
            HighestRankNumber Test3 = new HighestRankNumber();
            int[] input = { -1, -10, -15, -1, -10, -7 };
            int expected = -1;

            //Act
            int result = Test3.HighestRank(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return whichever number occurs the most times, in the event of a tie the larger number should be returned");
        }

        [TestMethod]
        public void HighestRankNumber_HighestRank_LargestAtStart()
        {
            //Arrange
            HighestRankNumber Test4 = new HighestRankNumber();
            int[] input = { 1000, 1, 1, 2 };
            int expected = 1;

            //Act
            int result = Test4.HighestRank(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return whichever number occurs the most times, in the event of a tie the larger number should be returned");
        }

        [TestMethod]
        public void HighestRankNumber_HighestRank_AllSame()
        {
            //Arrange
            HighestRankNumber Test5 = new HighestRankNumber();
            int[] input = { 9, 9, 9, 9, 9, 9 };
            int expected = 9;

            //Act
            int result = Test5.HighestRank(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return whichever number occurs the most times, in the event of a tie the larger number should be returned");
        }

    }
}
