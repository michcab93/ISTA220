using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2.Tests
{
    [TestClass()]
    public class ChickenTests
    {
        [TestMethod()]
        public void reproduceTest()
        {
            //arrange
            Chicken c = new Chicken("chicken", "ordinary");
            //act
            string reproduce = c.reproduce("laying eggs");
            //asert
            Assert.AreEqual(reproduce, "laying eggs");

        }
        /*
        [TestMethod()]
        public void feelTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void singTest()
        {
            Assert.Fail();
        }*/
    }
}