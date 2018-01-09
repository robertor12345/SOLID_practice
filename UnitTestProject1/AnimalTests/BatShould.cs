using Animals.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopulationTests.AnimalTests
{

    [TestFixture]
    class BatShould
    {

        public Bat Occupant;


        [SetUp]
        public void Test_setup()
        {
            Occupant = new Bat()
            {
                Fly = true,
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "flies",
                Hungry = false
            };

        }
        [Test]
        public void Bat_should_Fly()
        {
            var result = Occupant.Fly;
            var expected = true;
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Bat_should_breathe()
        {
            var result = Occupant.Breathe;
            var expected = "brrrrrrr";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Bat_should_eat()
        {
            var result = Occupant.Eat;
            var expected = "flies";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Bat_should_sleep()
        {
            var result = Occupant.Sleep;
            var expected = "zzzzzz";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Bat_should_be_able_to_decide_if_hungry()
        {
            var result = Occupant.Hungry;
            var expected = false;
            Assert.AreEqual(expected, result);

        }

    }
}
    
