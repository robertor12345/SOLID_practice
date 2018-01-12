using Animals.Models;
using Animals.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
   public class PopulateAnimals : iCreatePopulation
    {
            private CreateHumans _humans;
            private CreateBats _bats;
            private CreateBears _bear;
            private CreateSeaCow _seaCow;
            public List<iMammals> noahsArk;
           
            

            public List<iMammals> GenerateOccupants()
            {
             
                noahsArk = new List<iMammals>();
                _humans = new CreateHumans();
                _bats = new CreateBats();
                _bear = new CreateBears();
                _seaCow = new CreateSeaCow();

                noahsArk.Add(_humans.CreateAnOccupant());
                noahsArk.Add(_humans.CreateAnOccupant());
                noahsArk.Add(_bear.CreateAnOccupant());
                noahsArk.Add(_bear.CreateAnOccupant());
                noahsArk.Add(_bats.CreateAnOccupant());
                noahsArk.Add(_bats.CreateAnOccupant());
                noahsArk.Add(_seaCow.CreateAnOccupant());
                noahsArk.Add(_seaCow.CreateAnOccupant());


            return noahsArk;
            }
        }
    }
