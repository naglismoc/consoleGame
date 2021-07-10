using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class Elf : NPC
    {
        public Elf(Random rnd, int X, int Y) : base(rnd, X, Y)
        {
            this.Name = "Elf";
        }
    }
}
