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
    public class CowTests
    {
        [TestMethod()]
        public void TalkTest()
        {
            //arrange
            Cow first = new Cow("Joe", "Ordinary");
            //act
            string sound = first.Talk("Moo");
            //assert
            Assert.AreEqual(sound, "Mooo");
        }

        [TestMethod()]
        public void EatTest()
        {
            //arrange
            Cow c = new Cow("Fred", "Chick-fil-a");
            //act
            string food = c.Eat("Chicken sandwiches");
            //assert
            Assert.AreEqual(food, "chicken sandwiches");
        }

        [TestMethod()]
        public void DoTest()
        {
            //arrange
            Cow c = new Cow("Lola", "got milk cow");
            //act
            string does = c.Do("make milk");
            //assert
            Assert.AreEqual(does, "make milk");
        }
    }
}