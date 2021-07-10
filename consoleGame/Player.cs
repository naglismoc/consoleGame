using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class Player : Character
    {
        public Player(string Name)
        {
            this.Name = Name;
            this.AttackXp = 60;
            this.StrengthXp = 60;
            this.HitpointsXp = 600;
            this.DefenceXp = 60;
            Hitpoints = this.getLevel(this.HitpointsXp);
        }
        public void Attack(Goblin NPC)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public void Run()
        {

        }

     
    }
}
