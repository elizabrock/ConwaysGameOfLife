using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;
using System.Collections.Generic;

namespace GameOfLifeTests
{
    [TestClass]
    public class UnboundedWorldTests
    {
        [TestMethod]
        public void UnboundedWorldEnsureICanCreateInstance()
        {
            UnboundedWorld my_world = new UnboundedWorld();
            Assert.IsNotNull(my_world);
        }

        [TestMethod]
        public void UnboundedWorldEnsureTheWorldHasZeroCells()
        {
            /* Begin Arrange */
            UnboundedWorld my_world = new UnboundedWorld();
            /* End Arrange */

            /* Begin Act */
            int expected_number_of_cells = 0;
            int actual_number_of_cells = my_world.CellCount();
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(expected_number_of_cells, actual_number_of_cells);
            /* End Assert */
        }

        [TestMethod]
        public void UnboundedWorldEnsureThereAreCells()
        {
            /* Begin Arrange */
            UnboundedWorld my_world = new UnboundedWorld();
            /* End Arrange */

            /* Begin Act */
            int x = 4;
            int y = 3;
            my_world.AddCell(x,y);
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(1, my_world.CellCount());
            /* End Assert */
        }

        [TestMethod]
        public void UnboundedWorldEnsureCorrectNumberOfAliveNeighbors()
        {
            /* Begin Arrange */
            UnboundedWorld my_world = new UnboundedWorld();
            /* End Arrange */

            /* Begin Act */
            my_world.AddCell(4, 4);
            my_world.AddCell(4, 5);
            my_world.AddCell(4, 3);
            List<Cell> expected_alive_neighbors = new List<Cell>
            {
                new Cell { X = 4,Y=5},
                new Cell { X = 4,Y=3}
                
            };
            List<Cell> actual_alive_neighbors = my_world.AliveNeighbors(4, 4);
            int expected_alive_neighbors_count = 2;
            int actual_alive_neighbors_count = actual_alive_neighbors.Count;
            /* End Act */

            /* Begin Assert */
            //Assert.IsTrue(actual_alive_neighbors[0].Equals(new Cell { X = 4, Y = 5 }));


            //CollectionAssert.AreEqual(expected_alive_neighbors, actual_alive_neighbors);
            Assert.AreEqual(expected_alive_neighbors_count, actual_alive_neighbors_count);
            /* End Assert */
        }
    }

   
}
