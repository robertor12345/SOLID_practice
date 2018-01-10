using System;
using System.Collections.Generic;
using System.Text;
using Animals.Models;
using Animals.DataStore;

namespace Animals.NoahsArk
{
    class CreateHumans : iCreateAnimals
    {

        public iMammals CreateAnOccupant()
        {
            Human Occupant = new Human()
            {
                Name = "Ark occupant ",
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "dim sum",
                Hungry = false
            };

            return Occupant;
        }
         
    }
}
