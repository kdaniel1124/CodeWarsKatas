using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class VowelCountTests
    {
        [TestMethod]
        public void VowelCount_GetVowelCount_VowelsAndSpaces()
        {
            //Arrange
            VowelCount Test1 = new VowelCount();
            string input = "aa i oo i uu";
            int expected = 8;

            //Act
            int result = Test1.GetVowelCount(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return the amount of vowels in the input string.");
        }

        [TestMethod]
        public void VowelCount_GetVowelCount_CaseSensitiveVowels()
        {
            //Arrange
            VowelCount Test2 = new VowelCount();
            string input = "Are you coming?";
            int expected = 6;

            //Act
            int result = Test2.GetVowelCount(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return the amount of vowels in the input string regardless of their casing.");
        }

        [TestMethod]
        public void VowelCount_GetVowelCount_EmptyString()
        {
            //Arrange
            VowelCount Test3 = new VowelCount();
            string input = "";
            int expected = 0;

            //Act
            int result = Test3.GetVowelCount(input);

            //Assert
            Assert.AreEqual(expected, result, "If provided an empty string, method should simply return zero.");
        }

    }
}
