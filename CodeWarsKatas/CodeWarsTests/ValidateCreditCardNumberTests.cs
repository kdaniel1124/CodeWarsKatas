using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class ValidateCreditCardNumberTests
    {
        [TestMethod]
        public void ValidateCreditCardNumber_Validate_False()
        {
            //Arrange
            ValidateCreditCardNumber Test1 = new ValidateCreditCardNumber();
            string input = "6654 6310 43044";
            bool expected = false;

            //Act
            bool result = Test1.Validate(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
