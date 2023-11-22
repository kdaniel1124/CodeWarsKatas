using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass]
    public class GravityFlipTests
    {
        [TestMethod]
        public void GravityFlip_Flip_LeftGravity()
        {
            //Arrange
            GravityFlip Test1 = new GravityFlip();
            int[] inputArr = { 1, 3, 2, 5, 4, 4 };
            char inputDir = 'L';
            int[] expected = { 5, 4, 4, 3, 2, 1};

            //Act
            int[] result = Test1.Flip(inputDir, inputArr);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GravityFlip_Flip_RightGravity()
        {
            //Arrange
            GravityFlip Test2 = new GravityFlip();
            int[] inputArr = { 1, 3, 2, 10, 2, 5, 4, 4 };
            char inputDir = 'R';
            int[] expected = { 1, 2, 2, 3, 4, 4, 5, 10 };

            //Act
            int[] result = Test2.Flip(inputDir, inputArr);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GravityFlip_Flip_NoBlocks()
        {
            //Arrange
            GravityFlip Test3 = new GravityFlip();
            int[] inputArr = { };
            char inputDir = 'L';
            int[] expected = { };

            //Act
            int[] result = Test3.Flip(inputDir, inputArr);

            //Assert
            CollectionAssert.AreEqual(expected, result);
        }

    }
}
