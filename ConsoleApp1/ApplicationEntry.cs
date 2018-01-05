using Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace animals
{
    class ApplicationEntry
    {

        static void Main(string[] args)
        {

            Human rob = new Human();
            rob.Breathe();
            rob.Sleep();
            rob.Eat();

        }

    }
}
