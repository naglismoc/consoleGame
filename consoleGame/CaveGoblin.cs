using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class CaveGoblin : Goblin
    {

        public CaveGoblin(Random rnd, int X, int Y) : base(rnd, X, Y)
        {
            this.Name = "Cave Goblin";
        }

        public void stoneAttack()
        {
            Console.WriteLine("Nasty goblin just threw a stone at you!");
        }
    }
}
