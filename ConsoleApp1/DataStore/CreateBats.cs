using Animals.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    class CreateBats : iCreateAnimals
    {
        public iMammals CreateAnOccupant()
        {
            Bat Occupant = new Bat()
            {
                Fly = false,
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "dim sum",
                Hungry = false
            };

            return Occupant;
        }
    }
}
