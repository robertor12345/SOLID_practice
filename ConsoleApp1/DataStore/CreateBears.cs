using Animals.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    class CreateBears : iCreateAnimals
    {

        public iMammals CreateAnOccupant()
        {
            Bear Occupant = new Bear()
            {
                Roar = "Roaaar",
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "fish",
                Hungry = false
            };

            return Occupant;
        }
    }
}
