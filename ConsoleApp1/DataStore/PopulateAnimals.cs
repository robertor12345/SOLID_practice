using Animals.Models;
using Animals.NoahsArk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
   public class PopulateAnimals
    {
            private CreateHumans humans;
            private CreateBats bats;
            private CreateBears bear;
            private CreateSeaCow seaCow;
            public List<iMammals> NoahsArk;
            private int rand = 0;
            private int i;
            private IAnimalGenerator generator;

            public PopulateAnimals(IAnimalGenerator generator)
            {
                this.generator = generator;
            }

            public List<iMammals> GenerateOccupants()
            {
             
                NoahsArk = new List<iMammals>();
                humans = new CreateHumans();
                bats = new CreateBats();
                bear = new CreateBears();
                seaCow = new CreateSeaCow();


            //Convert.ChangeType(bats.CreateAnOccupant(i), iHuman);
                NoahsArk.Add(humans.CreateAnOccupant(i));
                NoahsArk.Add(humans.CreateAnOccupant(i));
                NoahsArk.Add(bear.CreateAnOccupant(i));
                NoahsArk.Add(bear.CreateAnOccupant(i));
                NoahsArk.Add(bats.CreateAnOccupant(i));
                NoahsArk.Add(bats.CreateAnOccupant(i));
           

            return NoahsArk;
            }
        }
    }
