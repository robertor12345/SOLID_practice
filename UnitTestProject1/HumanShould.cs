using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;
using NUnit.Framework;

namespace HumanShould
{
    [TestClass]
    public class HumanShould
    {

        Human testSubject = new Human();
        string[] list = new string[5];

        [TestInitialize]
        public void Test_setup()
        {

            list = Test_Subject();

        }

        [TestCleanup]
        public void Test_teardown()
        {

            list = Test_Subject();

        }


        [TestMethod]
        public void Human_should_breathe()
        {

            var result = list[0];
            var expected = "brrrrrrr";
            NUnit.Framework.Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Human_should_eat()
        {
            var result = list[2];
            var expected = "dim sum";
            NUnit.Framework.Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Human_should_sleep()
        {
            var result = list[1];
            var expected = "zzzzzz";
            NUnit.Framework.Assert.AreEqual(expected, result);

        }
        
        [TestCase("starving")]
        public void Human_should_be_able_to_decide_if_hungry(String hungry)
        {
            var result = list[1];
            var expected = hungry;
            NUnit.Framework.Assert.AreEqual(expected, result);

        }

        public string[] Test_Subject() {
            list [0] = testSubject.Breathe();
            list[1] = testSubject.Sleep();
            list[2] = testSubject.Eat();

            return list;
        } 
    }
}
