using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class SpoonerizeMeTests
    {
        [TestMethod]
        public void SpoonerizeMe_Spoonerize_Spoon()
        {
            //Arrange
            SpoonerizeMe Test1 = new SpoonerizeMe();
            string input = "Spoonerize Me";
            string expected = "Mpoonerize Se";

            //Act
            string result = Test1.Spoonerize(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpoonerizeMe_Spoonerize_Racecar()
        {
            //Arrange
            SpoonerizeMe Test2 = new SpoonerizeMe();
            string input = "Racecar racecar";
            string expected = "racecar Racecar";

            //Act
            string result = Test2.Spoonerize(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpoonerizeMe_Spoonerize_EmptyString()
        {
            //Arrange
            SpoonerizeMe Test3 = new SpoonerizeMe();
            string input = "";
            string expected = "";

            //Act
            string result = Test3.Spoonerize(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
