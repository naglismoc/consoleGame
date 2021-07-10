using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class Goblin : NPC
    {
        public Goblin(Random rnd, int X, int Y) :base(rnd, X, Y)
        {
            this.Name = "Goblin";
        }
        public void shout()
        {
            Console.WriteLine("Raaarghh!..");
        }
   
    }
}
