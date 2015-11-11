using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

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

    }

   
}
