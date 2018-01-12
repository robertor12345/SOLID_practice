using System;
using System.Collections.Generic;
using System.Text;
using Animals.Models;

namespace Animals.DataStore
{
    public class AnimalFactory
    {
        public T Create<T>() where T : iMammals, new()
        {
            return default(T);
        }
    }
}
