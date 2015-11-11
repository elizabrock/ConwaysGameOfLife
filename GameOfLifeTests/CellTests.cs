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

        [TestMethod]
        public void CellEnsureCellHasAPosition()
        {
            Cell my_cell = new Cell();
            Assert.AreEqual(0, my_cell.X);
            Assert.AreEqual(0, my_cell.Y);
        }

        [TestMethod]
        public void CellEnsureWeCanProvidePosition()
        {
            int x = 1;
            int y = 2;
            Cell my_cell = new Cell { X = x, Y = y};
            /* The same as:  
            Cell my_cell = new Cell();
            my_cell.X = x;
            my_cell.Y = y;
            */
            Assert.AreEqual(x, my_cell.X);
            Assert.AreEqual(y, my_cell.Y);
        }
    }
}
