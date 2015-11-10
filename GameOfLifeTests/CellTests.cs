using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void CellEnsureCellIsAlive()
        {
            // Object Initializer Syntax
            // Use Public setters when creating new instance
            Cell my_cell = new Cell { IsAlive = true };
            Assert.IsTrue(my_cell.IsAlive);
        }

        [TestMethod]
        public void CellEnsureCellIsDeadByDefault()
        {
            Cell my_cell = new Cell();
            Assert.IsFalse(my_cell.IsAlive);
        }
    }
}
