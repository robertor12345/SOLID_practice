using System;
using animals;

namespace Animals
{
     interface Human : iMammals 
    {

        string Breathe { get; set; }
        string Sleep { get; set; }
        string Eat { get; set; }


    }
}