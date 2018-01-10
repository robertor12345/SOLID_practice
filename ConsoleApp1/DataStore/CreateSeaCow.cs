using Animals.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    class CreateSeaCow : iCreateAnimals
    {
        public iMammals CreateAnOccupant()
        {
            SeaCow Occupant = new SeaCow()
            {
                Swim = true,
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "fish",
                Hungry = false
            };

            return Occupant;
        }
    }
}
