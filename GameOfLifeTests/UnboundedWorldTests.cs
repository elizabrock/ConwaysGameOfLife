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
    }
}
