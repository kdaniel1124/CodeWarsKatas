using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class DisemvowelTrollsTests
    {
        [TestMethod]
        public void DisemvowelTrolls_Disemvowel_Hello()
        {
            //Arrange
            DisemvowelTrolls Test1 = new DisemvowelTrolls();
            string input = "Hello Trolls!";
            string expected = "Hll Trlls!";

            //Act
            string result = Test1.Disemvowel(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return a version of input string with all vowels removed");
        }

        [TestMethod]
        public void DisemvowelTrolls_Disemvowel_OnlyVowels()
        {
            //Arrange
            DisemvowelTrolls Test1 = new DisemvowelTrolls();
            string input = "aeiou";
            string expected = "";

            //Act
            string result = Test1.Disemvowel(input);

            //Assert
            Assert.AreEqual(expected, result, "If entire string is made of vowels then method should simply return an empty string");
        }

        [TestMethod]
        public void DisemvowelTrolls_Disemvowel_YNoCount()
        {
            //Arrange
            DisemvowelTrolls Test3 = new DisemvowelTrolls();
            string input = "Why shyly spy?";
            string expected = "Why shyly spy?";

            //Act
            string result = Test3.Disemvowel(input);

            //Assert
            Assert.AreEqual(expected, result, "For the purposes of this method 'y' does not count as a vowel");
        }

    }
}
