using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    interface iSeaCow: iMammals
    {
        string Swim { get; set; }
    }
}
