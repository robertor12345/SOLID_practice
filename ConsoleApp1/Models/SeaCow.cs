using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    public class SeaCow : iSeaCow
    {
        public bool Swim { get; set; }
        public string Breathe { get; set; }
        public string Sleep { get; set; }
        public string Eat { get; set; }
        public bool Hungry { get; set; }
    }
}
