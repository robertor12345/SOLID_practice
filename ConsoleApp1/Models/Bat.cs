﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Models
{
    public class Bat : iBat
    {
        public bool Fly { get; set;}
        public string Breathe { get; set;}
        public string Sleep { get; set;}
        public string Eat { get; set;}
        public bool Hungry { get; set;}
    }
}
