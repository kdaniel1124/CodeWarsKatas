using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class MultiplesOfThreeOrFiveTests
    {
        [TestMethod]
        public void MultiplesOfThreeOrFive_Solution_NegativeValue()
        {
            //Arrange
            MultiplesOfThreeOrFive Test1 = new MultiplesOfThreeOrFive();
            int input = -10;
            int expected = 0;

            //Act
            int result = Test1.Solution(input);

            //Assert
            Assert.AreEqual(expected, result, "If input is a negative number the solution should simply return 0.");
        }

        [TestMethod]
        public void MultiplesOfThreeOrFive_Solution_BaseTen()
        {
            //Arrange
            MultiplesOfThreeOrFive Test2 = new MultiplesOfThreeOrFive();
            int input = 10;
            int expected = 23;

            //Act
            int result = Test2.Solution(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should take in an int and add up every real number between 0 and that int that is divisible by 3 or 5. Then return the sum.");
        }

        [TestMethod]
        public void MultiplesOfThreeOrFive_Solution_BigNumber()
        {
            //Arrange
            MultiplesOfThreeOrFive Test3 = new MultiplesOfThreeOrFive();
            int input = 200;
            int expected = 9168;

            //Act
            int result = Test3.Solution(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should take in an int and add up every real number between 0 and that int that is divisible by 3 or 5. Then return the sum.");
        }

    }
}
