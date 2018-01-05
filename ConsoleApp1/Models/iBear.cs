using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    interface iBear: iMammals
    {
        string Roar { get; set; }
    }
}
