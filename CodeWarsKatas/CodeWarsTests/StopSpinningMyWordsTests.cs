using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class StopSpinningMyWordsTests
    {
        [TestMethod]
        public void StopSpinningMyWords_SpinWords_EmptyString()
        {
            //Arrange
            StopSpinningMyWords Test1 = new StopSpinningMyWords();
            string input = "";
            string expected = "";

            //Act
            string result = Test1.SpinWords(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should only change strings with words five characters or longer.");
        }

        [TestMethod]
        public void StopSpinningMyWords_SpinWords_SomeLongWords()
        {
            //Arrange
            StopSpinningMyWords Test2 = new StopSpinningMyWords();
            string input = "My words will Absolutely not be spunned!";
            string expected = "My sdrow will yletulosbA not be !dennups";

            //Act
            string result = Test2.SpinWords(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should reverse the letters of all words that are five characters or longer.");
        }

        [TestMethod]
        public void StopSpinningMyWords_SpinWords_CloseInLength()
        {
            //Arrange
            StopSpinningMyWords Test3 = new StopSpinningMyWords();
            string input = "Five four three meat fiver";
            string expected = "Five four eerht meat revif";

            //Act
            string result = Test3.SpinWords(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should only change strings with words five characters or longer.");
        }

    }
}
