using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class FirstNonRepeatingCharacterTests
    {
        [TestMethod]
        public void FirstNonRepeatingCharacter_FirstNonRepeat_Capitalized()
        {
            //Arrange
            FirstNonRepeatingCharacter Test1 = new FirstNonRepeatingCharacter();
            string input = "Sampled SAMPLE";
            string expected = "d";

            //Act

            string result = Test1.FirstNonRepeat(input);

            //Assert
            Assert.AreEqual(expected, result, "");
        }

        [TestMethod]
        public void FirstNonRepeatingCharacter_FirstNonRepeat_EmptyString()
        {
            //Arrange
            FirstNonRepeatingCharacter Test2 = new FirstNonRepeatingCharacter();
            string input = "";
            string expected = "";

            //Act

            string result = Test2.FirstNonRepeat(input);

            //Assert
            Assert.AreEqual(expected, result, "If provided an empty string then method should simply return an empty string");
        }

        [TestMethod]
        public void FirstNonRepeatingCharacter_FirstNonRepeat_StressTest()
        {
            //Arrange
            FirstNonRepeatingCharacter Test3 = new FirstNonRepeatingCharacter();
            string input = "stress";
            string expected = "t";

            //Act

            string result = Test3.FirstNonRepeat(input);

            //Assert
            Assert.AreEqual(expected, result, "");
        }

    }
}
