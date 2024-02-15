using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class SendInTheClonesTests
    {
        [TestMethod]
        public void SendInTheClones_CloneWars_ZeroKatas()
        {
            //Arrange
            SendInTheClones Test1 = new SendInTheClones();
            int kataInput = 0;
            int[] expected = { 1, 0 };

            //Act
            int[] result = Test1.CloneWars(kataInput);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }

    }
}
