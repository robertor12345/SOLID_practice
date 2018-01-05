using Animals.NoahsArk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
   public class CreateMultipleAnimals
    {

        private CreateHumans humans;
        private CreateBats bats;
        public List<iMammals> NoahsArk;

        public List<iMammals> GenerateOccupants()
        {
            NoahsArk = new List<iMammals>();
            humans = new CreateHumans();
            bats = new CreateBats();
            Random rnd = new Random();
            var rand = 0;

            for (int i = 0; i < 200; i++)
            {
                rand = rnd.Next();
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

