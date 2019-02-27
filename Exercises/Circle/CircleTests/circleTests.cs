using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Tests  //adds .test to class
{
    [TestClass()] // this is a attribute/declaration 
    public class circleTests //name of class testing plus test
    {
        [TestMethod()]
        public void AreaTest() //method name plus test 
        {
            // arrange
            circle cir = new circle(1);
            // act (invoces method)
            double a = cir.Area(1);
            //assert (says fail passed)
            Assert.AreEqual(a, Math.PI);
            // Assert.Fail();
        }

        [TestMethod()]
        public void CircumTest()
        {
            //arrange
            circle ball = new circle(1);
            //act
            double c = ball.Circum(1);  //calling the method and assigning a testable variable
            //assert
            Assert.AreEqual(c, 2 * Math.PI); // what you know is the anser and comparing it to method result 
        }
    }
}