using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class CountingDuplicatesTests
    {
        [TestMethod]
        public void CountingDuplicates_CountDuplicates_NoDupes()
        {
            //Arrange
            CountingDuplicates Test1 = new CountingDuplicates();
            string input = "aeiou";
            int expected = 0;

            //Act
            int result = Test1.DuplicateCount(input);

            //Assert
            Assert.AreEqual(expected, result, "If string contains no duplicate characters then the method should simply return 0.");
        }
       
        [TestMethod]
        public void CountingDuplicates_CountDuplicates_RepeatThree()
        {
            //Arrange
            CountingDuplicates Test2 = new CountingDuplicates();
            string input = "123123123123";
            int expected = 3;

            //Act
            int result = Test2.DuplicateCount(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return the amount of unique characters that occur at least twice, not the amount of times they occur.");
        }
       
        [TestMethod]
        public void CountingDuplicates_CountDuplicates_EmptyString()
        {
            //Arrange
            CountingDuplicates Test3 = new CountingDuplicates();
            string input = "";
            int expected = 0;

            //Act
            int result = Test3.DuplicateCount(input);

            //Assert
            Assert.AreEqual(expected, result, "If input string is empty then there are no duplicates and method should return 0.");
        }
       
    }
}
