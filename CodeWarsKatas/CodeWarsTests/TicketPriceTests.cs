using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class TicketPriceTests
    {
        [TestMethod]
        public void TicketPrice_GetPrice_LessThanFivePeopleIsWeekendNoAdults()
        {
            //Arrange
            TicketPrice Test1 = new TicketPrice();
            List<int> input = new List<int> { 1, 5, 7, 17 };
            decimal expected = 23.00m;

            //Act
            decimal result = Test1.GetPrice(input, true);

            //Assert
            Assert.AreEqual(expected, result, "Whether or not it is a weekend only affects the price for adult and senior tickets.");
        }

        [TestMethod]
        public void TicketPrice_GetPrice_FivePeopleIsWeekendNoAdults()
        {
            //Arrange
            TicketPrice Test2 = new TicketPrice();
            List<int> input = new List<int> { 1, 5, 7, 17, 2 };
            decimal expected = 25.20m;

            //Act
            decimal result = Test2.GetPrice(input, true);

            //Assert
            Assert.AreEqual(expected, result, "Once there are five or more tickets in the order a 10% discount should be applied to the final bill.");
        }

        [TestMethod]
        public void TicketPrice_GetPrice_LessThanFivePeopleIsWeekendWithAdults()
        {
            //Arrange
            TicketPrice Test3 = new TicketPrice();
            List<int> input = new List<int> { 1, 69, 41, 26 };
            decimal expected = 40.70m;

            //Act
            decimal result = Test3.GetPrice(input, true);

            //Assert
            Assert.AreEqual(expected, result, "If it is a weekend, then adult and senior tickets should have a 5% surcharge.");
        }

    }
}
