using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.DataStore
{
    public interface iCreatePopulation
    {

         List<iMammals> GenerateOccupants();
    }
}
