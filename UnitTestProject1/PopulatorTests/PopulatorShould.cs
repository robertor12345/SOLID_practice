using System;
using Animals;
using NUnit.Framework;
using Animals.Models;
using Animals.DataStore;
using System.Collections.Generic;
using System.Diagnostics;

namespace PopulatorShould
{
    [TestFixture]
    public class PopulatorShould
    {
        [SetUp]
        public void Test_setup()
        {
            
        }

        private List<iMammals> GetMammals()
        {
            var generator = new RandomAnimalGenerator();
            var population = new CreateMultipleAnimals(generator);
            var testPopulation = population.GenerateOccupants();

            return testPopulation;
        }

        [Test]
        public void Population_size_greater_than_0()
        {
            var result = GetMammals().Count;
            var expected = 0;

            Assert.Greater(result, expected);
        }

        [Test]
        public void Population_should_be_random()
        {
            var result = GetMammals();
            var expected = GetMammals();
            //CollectionAssert.AreNotEquivalent(result, expected);

            int numberSame = 0;
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].GetType() == expected[i].GetType())
                {
                    numberSame++;
                    Trace.WriteLine($"{i} : {result[i].GetType()} , {expected[i].GetType()}");
                }
            }

            Assert.AreNotEqual(numberSame, result.Count);
        }

        [Test]
        public void Population_should_contain_at_least_one_of_each_type()
        {
            var result = GetMammals();
            //NUnit.Framework.Assert.AreEqual(result.GetType(), typeof(iMammals));
            //NUnit.Framework.CollectionAssert.Contains(result, );
        }

    }
}
