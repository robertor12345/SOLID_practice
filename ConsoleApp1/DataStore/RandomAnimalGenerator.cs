using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    public class RandomAnimalGenerator : IAnimalGenerator
    {
        private static readonly Random Random = new Random();

        public int Next()
        {
            return Random.Next();
        }
    }
}
