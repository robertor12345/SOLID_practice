
using System.Collections.Generic;

namespace Animals.DataStore
{

    public class CreateMultipleRandomAnimals : iCreatePopulation
    {
        private CreateHumans _humans;
        private CreateBats _bats;
        public List<iMammals> NoahsArk;
        private int i;
        private readonly IAnimalGenerator _generator;

        public CreateMultipleRandomAnimals(IAnimalGenerator generator)
        {
            this._generator = generator;
        }

        public List<iMammals> GenerateOccupants()
        {
            NoahsArk = new List<iMammals>();
            _humans = new CreateHumans();
            _bats = new CreateBats();

            for (i = 0; i < 200; i++)
            {
                var rand = _generator.Next();
                switch (rand % 2)
                {

                    case 0:
                        NoahsArk.Add(_humans.CreateAnOccupant());
                        break;
                    case 1:
                        NoahsArk.Add(_bats.CreateAnOccupant());
                        break;
                    default:
                        NoahsArk.Add(_bats.CreateAnOccupant());
                        break;
                }

            }

            return NoahsArk;
        }
    }
}