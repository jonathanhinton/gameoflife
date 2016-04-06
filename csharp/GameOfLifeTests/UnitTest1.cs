using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class UnitTest1
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

            //act
            newWorld.spaces[0,0] = ;
            int[,] expected = new int[,] { {0, 0}, { 0, 0 }, { 2, 2 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };

            //assert
            Assert.AreEqual(expected, newWorld);
        }
    }
}
