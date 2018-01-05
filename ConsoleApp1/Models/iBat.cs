using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    interface iBats: iMammals
    {
        bool Fly { get; set; }
    }
}
