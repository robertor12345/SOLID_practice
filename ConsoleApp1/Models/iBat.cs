using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    interface iBat: iMammals
    {
        bool Fly { get; set; }
    }
}
