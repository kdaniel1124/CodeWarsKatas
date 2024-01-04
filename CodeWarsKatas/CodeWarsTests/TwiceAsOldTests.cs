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
        public void TwiceAsOldSolution_TwiceAsOld_CorrectStart()
        {
            //Arrange
            TwiceAsOldSolution Test1 = new TwiceAsOldSolution();
            int dadAge = 40;
            int sonAge = 20;
            int expected = 0;

            //Act
            int result = Test1.TwiceAsOld(dadAge, sonAge);

            //Assert
            Assert.AreEqual(expected, result, "Method should calculate in how many years (or how many years ago) the dad will be/was exactly twice as old as the son");
        }

        [TestMethod]
        public void TwiceAsOldSolution_TwiceAsOld_()
        {
            //Arrange
            TwiceAsOldSolution Test2 = new TwiceAsOldSolution();
            int dadAge = 24;
            int sonAge = 6;
            int expected = 12;

            //Act
            int result = Test2.TwiceAsOld(dadAge, sonAge);

            //Assert
            Assert.AreEqual(expected, result, "Method should calculate in how many years (or how many years ago) the dad will be/was exactly twice as old as the son");
        }

        [TestMethod]
        public void TwiceAsOldSolution_TwiceAsOld_InThePast()
        {
            //Arrange
            TwiceAsOldSolution Test3 = new TwiceAsOldSolution();
            int dadAge = 45;
            int sonAge = 25;
            int expected = 5;

            //Act
            int result = Test3.TwiceAsOld(dadAge, sonAge);

            //Assert
            Assert.AreEqual(expected, result, "Method should calculate in how many years (or how many years ago) the dad will be/was exactly twice as old as the son");
        }

    }
}
