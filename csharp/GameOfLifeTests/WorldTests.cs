using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void NotNull()
        {
            //arrange
            World newWorld = new World(8);
            //assert
            Assert.IsNotNull(newWorld);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeOrZeroInputThrowsException()
        {
            //arrange
            World newWorld = new World(0);
        }

        [TestMethod]
        public void CheckTotalSpaces()
        {
            //arrange
            World newWorld = new World(8);

            //assert
            Assert.AreEqual(64, newWorld.spaces.Length);
        }

        [TestMethod]
        public void CheckFirstIndex()
        {
            //arrange
            World newWorld = new World(8);

            //assert
            Assert.AreEqual(0, newWorld.spaces[0, 0]);
        }

        [TestMethod]
        public void CheckLastIndex()
        {
            //arrange
            World newWorld = new World(8);

            //assert
            Assert.AreEqual(0, newWorld.spaces[7, 7]);
        }
    }
}
