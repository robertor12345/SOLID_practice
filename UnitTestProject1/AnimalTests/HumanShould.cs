
using Animals;
using NUnit.Framework;
using Animals.Models;
using Animals.DataStore;

namespace PopulationTests.AnimalTests
{
    [TestFixture]
    public class HumanShould
    {
        private AnimalFactory _factory;
        private iHuman _occupant;


        [SetUp]
        public void Test_setup()
        {
            _factory = new AnimalFactory();
            _occupant = _factory.Create<Human>();
            _occupant.Name = "Ark occupant ";
            _occupant.Breathe = "brrrrrrr";
            _occupant.Sleep = "zzzzzz";
            _occupant.Eat = "dim sum";
            _occupant.Hungry = false;

        }

        [Test]
        public void Test_teardown()
        {

           

        }


        [Test]
        public void Human_should_breathe()
        {
            
            
            var result = _occupant.Breathe;
            var expected = "brrrrrrr";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Human_should_eat()
        {
            var result = _occupant.Eat;
            var expected = "dim sum";
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Human_should_sleep()
        {
            var result = _occupant.Sleep;
            var expected = "zzzzzz";
            Assert.AreEqual(expected, result);

        }
        
        [Test]
        public void Human_should_be_able_to_decide_if_hungry()
        {
            var result = _occupant.Hungry;
            var expected = false;
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Human_Name_attribute_should_be_random()
        {

            var expectedHuman=_factory.Create<Human>();
            var resultHuman = _occupant;
            var result = resultHuman.Name;
            var expected = expectedHuman.Name;
            Assert.AreNotEqual(expected, result);

        }



    }
}
