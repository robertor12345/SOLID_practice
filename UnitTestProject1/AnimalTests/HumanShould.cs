using System;

using Animals;

using NUnit.Framework;
using Animals.Models;

namespace HumanShould
{
    [TestFixture]
    public class HumanShould 
    {

        public Human Occupant;


       [SetUp]
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

        [Test]
        public void Test_teardown()
        {

           

        }


        [Test]
        public void Human_should_breathe()
        {
            var result = Occupant.Breathe;
            var expected = "brrrrrrr";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Human_should_eat()
        {
            var result = Occupant.Eat;
            var expected = "dim sum";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Human_should_sleep()
        {
            var result = Occupant.Sleep;
            var expected = "zzzzzz";
            Assert.AreEqual(expected, result);

        }
        
        [Test]
        public void Human_should_be_able_to_decide_if_hungry()
        {
            var result = Occupant.Hungry;
            var expected = false;
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Human_Name_attribute_should_be_random()
        {
            var result = Occupant.Name;
            var expected = false;
            Assert.AreEqual(expected, result);

        }



    }
}
