using Animals.Models;
using Animals.NoahsArk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
   public class PopulateAnimals : iCreatePopulation
    {
            private CreateHumans humans;
            private CreateBats bats;
            private CreateBears bear;
            private CreateSeaCow seaCow;
            public List<iMammals> noahsArk;
           
            

            public List<iMammals> GenerateOccupants()
            {
             
                noahsArk = new List<iMammals>();
                humans = new CreateHumans();
                bats = new CreateBats();
                bear = new CreateBears();
                seaCow = new CreateSeaCow();

                noahsArk.Add(humans.CreateAnOccupant());
                noahsArk.Add(humans.CreateAnOccupant());
                noahsArk.Add(bear.CreateAnOccupant());
                noahsArk.Add(bear.CreateAnOccupant());
                noahsArk.Add(bats.CreateAnOccupant());
                noahsArk.Add(bats.CreateAnOccupant());
                noahsArk.Add(seaCow.CreateAnOccupant());
                noahsArk.Add(seaCow.CreateAnOccupant());


            return noahsArk;
            }
        }
    }
