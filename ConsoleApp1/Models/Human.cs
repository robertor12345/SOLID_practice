using System;
using System.Collections.Generic;
using System.Text;

using Animals;

namespace Animals.Models
{
    public class Human : iHuman
    {
        public string Breathe { get ; set ; }
        public string Sleep { get; set; }
        public string Eat { get; set; }
        public string Name { get; set; }
        public bool Hungry { get; set; }
    }
}
