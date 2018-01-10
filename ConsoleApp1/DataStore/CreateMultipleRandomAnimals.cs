using Animals.NoahsArk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{

    public class CreateMultipleRandomAnimals : iCreatePopulation
    {
        private CreateHumans humans;
        private CreateBats bats;
        public List<iMammals> NoahsArk;
        private int rand = 0;
        private int i;
        private IAnimalGenerator generator;

        public CreateMultipleRandomAnimals(IAnimalGenerator generator)
        {
            this.generator = generator;
        }

        public List<iMammals> GenerateOccupants()
        {
            NoahsArk = new List<iMammals>();
            humans = new CreateHumans();
            bats = new CreateBats();

            for (i = 0; i < 200; i++)
            {
                var rand = generator.Next();
                switch (rand % 2)
                {

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