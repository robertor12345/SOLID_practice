using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    public class AnimalGenerator : IAnimalGenerator
    {
        private const int SetSeed = 0;

        public int Next()
        {
            var random = new Random(SetSeed);
            return random.Next();
        }
    }
}
