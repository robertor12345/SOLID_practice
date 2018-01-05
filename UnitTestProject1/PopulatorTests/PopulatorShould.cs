using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;

using NUnit.Framework;
using Animals.Models;
using Animals.DataStore;
using System.Collections.Generic;

namespace PopulatorShould
{
    [TestClass]
    public class PopulatorShould
    {
        private CreateMultipleAnimals population;
        private List<iMammals> TestPopulation;

        [TestInitialize]
        public void Test_setup()
        {
           population = new CreateMultipleAnimals();
           TestPopulation = population.GenerateOccupants();

        }


        [TestMethod]
        public void Population_size_greater_than_0()
        {
            var result = TestPopulation.Count;
            var expected = 0;
            NUnit.Framework.Assert.Greater(result, expected);

        }

        [TestMethod]
        public void Population_should_be_random()
        {
            var result = TestPopulation;
            var expected = population.GenerateOccupants();
            NUnit.Framework.CollectionAssert.AreNotEquivalent(result, expected);

        }

    }
}
