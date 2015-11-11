using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class BoundedWorldTests
    {
        [TestMethod]
        public void WorldEnsureICanCreateInstance()
        {
            BoundedWorld my_world = new BoundedWorld();
            Assert.IsNotNull(my_world);
        }

        [TestMethod]
        public void BoundedWorldEnsureWorldIsSmallerThanMax()
        {
            /* Begin Arrange */
            int height = 80;
            int width = 80;
            /* End Arrange */

            /* Begin Act */
            BoundedWorld my_world = new BoundedWorld(width, height);
            /* End Act */

            /* Begin Assert */
            Assert.IsNotNull(my_world);
            /* End Assert */
        }

        [TestMethod]
        public void BoundedWorldEnsureIHaveArrayOfCorrectSize()
        {
            /* Begin Arrange */
            int height = 80;
            int width = 80;
            BoundedWorld my_world = new BoundedWorld(width, height);
            int expected_height = height;
            int expected_width = width;
            /* End Arrange */

            /* Begin Act */
            int actual_height = my_world.Height;
            int actual_width = my_world.Width;
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(expected_height, actual_height);
            Assert.AreEqual(expected_width, actual_width);
            /* End Assert */
        }

        [TestMethod]
        public void BoundedWorldEnsureWorldHasCells()
        {
            /* Begin Arrange */
            int height = 100;
            int width = 100;
            BoundedWorld my_world = new BoundedWorld(width, height);
            /* End Arrange */

            /* Begin Act */
            int expected_number_of_dead_cells = 10000;
            int expected_number_of_alive_cells = 0;
            int actual_number_of_dead_cells = my_world.DeadCellCount();
            int actual_number_of_alive_cells = my_world.AliveCellCount();
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(expected_number_of_dead_cells, actual_number_of_dead_cells);
            Assert.AreEqual(expected_number_of_alive_cells, actual_number_of_alive_cells);
            /* End Assert */
        }

        [TestMethod]
        public void BoundedWorldEnsureThereAreCells()
        {
            /* Begin Arrange */
            int width = 80;
            int height = 80;
            BoundedWorld my_world = new BoundedWorld(width, height);
            /* End Arrange */

            /* Begin Act */
            int x = 4;
            int y = 3;
            my_world.AddCell(x, y);
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(1, my_world.AliveCellCount());
            /* End Assert */
        }

        [TestMethod]
        public void BoundedWorldApplyUnderPopulationToOneCell()
        {
            /* Begin Arrange */
            BoundedWorld my_world = new BoundedWorld(10, 10);
            my_world.AddCell(4, 5);
            /* End Arrange */

            /* Begin Act */
            my_world.UnderPopulationRule();
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(0, my_world.AliveCellCount());
            /* End Assert */
        }

        [TestMethod]
        public void BoundedWorldEnsureThereAreZeroLiveNeighbors()
        {
            /* Begin Arrange */
            BoundedWorld my_world = new BoundedWorld(10, 10);
            /* End Arrange */

            /* Begin Act */
            int expected_alive_neighbors = 0;
            int actual_alive_neighbors = my_world.AliveNeighborCount(4, 5);
            /* End Act */

            /* Begin Assert */
            Assert.AreEqual(expected_alive_neighbors, actual_alive_neighbors);
            /* End Assert */
        }

        [TestMethod]
        public void MyTestMethod()
        {
            /* Begin Arrange */
            /* End Arrange */

            /* Begin Act */
            /* End Act */

            /* Begin Assert */
            /* End Assert */
        }
    }
}
