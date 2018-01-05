using System;
using animals;

namespace Animals
{
    public interface iHuman : iMammals 
    {

        string Breathe { get; set; }
        string Sleep { get; set; }
        string Eat { get; set; }
        string Name { get; set; }
        bool Hungry { get; set; }


    }
}