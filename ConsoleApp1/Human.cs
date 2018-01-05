using System;

namespace Animals
{
    public class Human : iMammals 
    {
        static void Main(string[] args)
        {

            Human rob = new Human();
            rob.Breathe();
            rob.Sleep();
            rob.Eat();

        }

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