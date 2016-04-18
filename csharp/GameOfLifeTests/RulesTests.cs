using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class RulesTests
    {
        [TestMethod]
        public void RulesAreNotNull()
        {
            Rules rules = new Rules();
            Assert.IsNotNull(rules);
        }
[TestMethod]
        public void countTheNeighborsOnBlock()
        {
            World world = new World(7);
            Rules rules = new Rules();
            Multiverse neighborhoods = new Multiverse();

            World blockWorld = neighborhoods.block(world);
            int neighborsAmount = rules.neighborCounter(3,3,blockWorld);
            Assert.AreEqual(3, neighborsAmount);                       
        }
        [TestMethod]
        public void countTheNeighborsOnDeadCellonBlock()
        {
            World world = new World(7);
            Rules rules = new Rules();
            Multiverse neighborhoods = new Multiverse();

            World blockWorld = neighborhoods.block(world);
            int neighborsAmount = rules.neighborCounter(3, 2, blockWorld);
            Assert.AreEqual(0, world.spaces[4,2]);            
        }
        [TestMethod]
        public void CountLiveCellsOnIterationOnBlock()
        {
            World world = new World(7);
            Rules rules = new Rules();
            Multiverse neighborhoods = new Multiverse();
            World blockWorld = neighborhoods.block(world);
            int counter = 0;
            while (rules.days < 5)
            {
                for (int row = 0; row < blockWorld.spaces.GetLength(0); row++)
                {
                    for (int col = 0; col < blockWorld.spaces.GetLength(1); col++)
                    {
                        int neighbors = rules.neighborCounter(row, col, blockWorld); //counts the neighbors around instance of cell
                        rules.PopulatePotentialWorld(row, col, neighbors, blockWorld); //sets the value in limbo world at coordinate
                        rules.days++;
                    }
                }
                blockWorld.spaces = (int[,]) blockWorld.potentialSpaces.Clone();
                Array.Clear(blockWorld.potentialSpaces, 0, blockWorld.potentialSpaces.Length);
            }
            for (int row = 0; row < blockWorld.spaces.GetLength(0); row++)
            {
                for (int col = 0; col < blockWorld.spaces.GetLength(1); col++)
                {
                    if(blockWorld.spaces[row,col] == 1)
                    {
                        counter++;
                    }
                }
            }

            Assert.AreEqual(4, counter);

        }
    }
}
