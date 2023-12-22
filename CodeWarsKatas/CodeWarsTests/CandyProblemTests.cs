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
    }
}
