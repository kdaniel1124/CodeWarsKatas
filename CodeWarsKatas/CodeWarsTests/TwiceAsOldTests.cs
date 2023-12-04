using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class TwiceAsOldTests
    {
        [TestMethod]
        public void TwiceAsOldSolution_TwiceAsOld_ExactStart()
        {
            //Arrange
            TwiceAsOldSolution Test1 = new TwiceAsOldSolution();
            int dadAge = 40;
            int sonAge = 20;
            int expected = 20;

            //Act
            int result = Test1.TwiceAsOld(dadAge, sonAge);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwiceAsOldSolution_TwiceAsOld_()
        {
            //Arrange
            TwiceAsOldSolution Test1 = new TwiceAsOldSolution();
            int dadAge = 24;
            int sonAge = 6;
            int expected = 0;

            //Act
            int result = Test1.TwiceAsOld(dadAge, sonAge);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
