using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;

using NUnit.Framework;
using Animals.Models;

namespace HumanShould
{
    [TestClass]
    public class HumanShould 
    {

        public Human Occupant;


       [TestInitialize]
        public void Test_setup()
        {
             Occupant = new Human()
             {
                 Name = "test occupant ",
                 Breathe = "brrrrrrr",
                 Sleep = "zzzzzz",
                 Eat = "dim sum",
                 Hungry = false
             };

        }

        [TestCleanup]
        public void Test_teardown()
        {

           

        }


        [TestMethod]
        public void Human_should_breathe()
        {

            var result = Occupant.Breathe;
            var expected = "brrrrrrr";
            NUnit.Framework.Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Human_should_eat()
        {
            var result = Occupant.Eat;
            var expected = "dim sum";
            NUnit.Framework.Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Human_should_sleep()
        {
            var result = Occupant.Sleep;
            var expected = "zzzzzz";
            NUnit.Framework.Assert.AreEqual(expected, result);

        }
        
        [TestCase("starving")]
        public void Human_should_be_able_to_decide_if_hungry(String hungry)
        {
            var result = Occupant.Hungry;
            var expected = false;
            NUnit.Framework.Assert.AreEqual(expected, result);

        }

        
    }
}
