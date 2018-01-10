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

        private List<iMammals> GetMammals(IAnimalGenerator generator, iCreatePopulation population)
        {
            var testPopulation = population.GenerateOccupants();

            return testPopulation;
        }

 
        [Test]
        public void Population_size_greater_than_0()
        {
            
            var generator = new RandomAnimalGenerator();
            var population = new CreateMultipleRandomAnimals(generator);
            var result = GetMammals(generator, population).Count;
            var expected = 0;

            Assert.Greater(result, expected);
        }

        [Test]
        public void Population_should_be_random()
        {
            var generator = new RandomAnimalGenerator();
            var population = new CreateMultipleRandomAnimals(generator);
            var result = GetMammals(generator, population);
            var expected = GetMammals(generator, population);

            var numberSame = 0;
            for (var i = 0; i < result.Count; i++)
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
            var generator = new AnimalGenerator();
            var population = new PopulateAnimals();
            var result = GetMammals(generator, population);
            var expected = result.Count / 2;

            var numberSame = 0;
            for (var i = 0; i < result.Count-1; i++)
            {

                Console.WriteLine("the objetc type is: "+result[i].GetType());
                if (result[i].GetType() == result[i+1].GetType())
                {
                    numberSame++;
                    Trace.WriteLine($"{i} : {result[i].GetType()} , {result[i+1].GetType()}");
                }
            }

            Assert.AreEqual(expected, numberSame);

        }

    }
}
