using Animals.NoahsArk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
   public class CreateMultipleAnimals
    {

        private CreateHumans humans;
        public List<iMammals> NoahsArk;

        public List<iMammals> GenerateOccupants()
        {
            NoahsArk = new List<iMammals>();
            humans = new CreateHumans();

            Random rnd = new Random();
            var rand = 0;

            for (int i = 0; i < 10; i++)
            {
                rand = rnd.Next();
                NoahsArk.Add(humans.CreateAnOccupant(i));
            }

            return NoahsArk;
        }
    }
}

