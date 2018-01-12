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
            Bear occupant = new Bear()
            {
                Roar = "Roaaar",
                Breathe = "brrrrrrr",
                Sleep = "zzzzzz",
                Eat = "fish",
                Hungry = false
            };

            return occupant;
        }

        public void DoSomething()
        {
            var factory = new AnimalFactory();

            var bear = factory.Create<Bear>();

           
        }
    }
}
