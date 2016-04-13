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
        public void InitialGameBoardSetup()
        {
            World newWorld = new World(8);
            Rules rules = new Rules();

            
        }
    }
}
