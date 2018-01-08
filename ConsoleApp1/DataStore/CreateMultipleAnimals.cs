using Animals.NoahsArk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    public interface IAnimalGenerator
    {
        int Next();
    }

    public class RandomAnimalGenerator : IAnimalGenerator
    {
        public int Next()
        {
            var random = new Random(DateTime.UtcNow.Millisecond);
            return random.Next();
        }
    }

    public class AnimalGenerator : IAnimalGenerator
    {
        private const int SetSeed = 0;
        
        public int Next()
        {
            var random = new Random(SetSeed);
            return random.Next();
        }
    }

    public class CreateMultipleAnimals
    {
        private CreateHumans humans;
        private CreateBats bats;
        public List<iMammals> NoahsArk;
        private int rand = 0;
        private int i;
        private IAnimalGenerator generator;

        public CreateMultipleAnimals(IAnimalGenerator generator)
        {
            this.generator = generator;
        }

        public List<iMammals> GenerateOccupants()
        {
            NoahsArk = new List<iMammals>();
            humans = new CreateHumans();
            bats = new CreateBats();
            
            rand = 0;

            for (i = 0; i < 200; i++)
            {
                rand = generator.Next();
                switch (rand%2) {

                    case 0:
                        NoahsArk.Add(humans.CreateAnOccupant(i));
                        break;
                    case 1:
                        NoahsArk.Add(bats.CreateAnOccupant(i));
                        break;
                }         
                
            }

            return NoahsArk;
        }
    }
}

