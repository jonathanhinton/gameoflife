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
        public void SettingArrayIndices()
        {
            //arrange
            World newWorld = new World(8);

            //assert
            Assert.AreEqual(64, newWorld.spaces.Length);
        }
    }
}
