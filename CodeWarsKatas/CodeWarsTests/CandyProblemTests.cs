using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class CandyProblemTests
    {
        [TestMethod]
        public void CandyProblem_GetMissingCandies_AlreadyBalanced()
        {
            //Arrange
            CandyProblem Test1 = new CandyProblem();
            int[] input = { 10, 10, 10, 10};
            int expected = 0;

            //Act
            int result = Test1.GetMissingCandies(input);

            //Assert
            Assert.AreEqual(expected, result, "If all candy amounts are already the same, then there is no need to add any extra.");
        }

        [TestMethod]
        public void CandyProblem_GetMissingCandies_EmptyArray()
        {
            //Arrange
            CandyProblem Test1 = new CandyProblem();
            int[] input = { };
            int expected = -1;

            //Act
            int result = Test1.GetMissingCandies(input);

            //Assert
            Assert.AreEqual(expected, result, "If provided an array of length 1 or less, the method should return -1.");
        }

        [TestMethod]
        public void CandyProblem_GetMissingCandies_LargeGap()
        {
            //Arrange
            CandyProblem Test1 = new CandyProblem();
            int[] input = { 0, 20, 1, 1};
            int expected = 58;

            //Act
            int result = Test1.GetMissingCandies(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return the number of candies needed to bring all kids up to the highest amount in the array.");
        }

    }
}
