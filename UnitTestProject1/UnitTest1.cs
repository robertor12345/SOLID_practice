using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;

namespace UnitTestProject1
{
    [TestClass]
    public class HumanShould
    {
        [TestMethod]
        public void Human_should_breathe()
        {
            Human testSubject = new Human();
            var result = testSubject.Breathe();
            var expected = "brrrrrrr";
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Human_should_eat()
        {
            Human testSubject = new Human();
            var result = testSubject.Eat();
            var expected = "dim sum";
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Human_should_sleep()
        {
            Human testSubject = new Human();
            var result = testSubject.Sleep();
            var expected = "zzzzzz";
            Assert.AreEqual(expected, result);

        }
    }
}
