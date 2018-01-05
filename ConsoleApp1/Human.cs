using System;

namespace Animals
{
    public class Human : iMammals 
    {

        public string Breathe()
        {
            var breath = "brrrrrrr";
            return breath;
        }

        public string Eat()
        {
            var food = "dim sum";
            return food;
        }

        public string Sleep()
        {
            var snoring = "zzzzzz";
            return snoring;
        }

      
    }
}