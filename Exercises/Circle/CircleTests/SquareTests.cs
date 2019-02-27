using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            //arrange 
            Square claude = new Square(1);
            //act
            double a = claude.Area(2);
            //assert
            Assert.AreEqual(a, 4);
        }
      
        [TestMethod()]
        public void PerimeterTest()
        {
            Square sally = new Square(1);

            int p = sally.Perimeter(7);

            Assert.AreEqual(p, 28);
        }
    }
}