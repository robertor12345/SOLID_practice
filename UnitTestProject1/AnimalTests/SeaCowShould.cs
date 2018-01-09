using Animals.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopulationTests.AnimalTests
{

    [TestFixture]
    class SeaCowShould
    {

        public SeaCow Occupant;

        [SetUp]
        public void Test_setup()
        {
            Occupant = new SeaCow()
            {
                Swim = true,
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "fish",
                Hungry = false
            };

        }

        [Test]
        public void SeaCow_should_roar()
        {
            var result = Occupant.Swim;
            var expected = true;
            Assert.AreEqual(expected, result);

        }


        [Test]
        public void SeaCow_should_breathe()
        {
            var result = Occupant.Breathe;
            var expected = "brrrrrrr";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void SeaCow_should_eat()
        {
            var result = Occupant.Eat;
            var expected = "fish";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void SeaCow_should_sleep()
        {
            var result = Occupant.Sleep;
            var expected = "zzzzzz";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void SeaCow_should_be_able_to_decide_if_hungry()
        {
            var result = Occupant.Hungry;
            var expected = false;
            Assert.AreEqual(expected, result);

        }
    }
}
