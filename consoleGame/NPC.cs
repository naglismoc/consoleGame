using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class NPC : Character
    {
        public bool Aggresive { get; set; }
        public NPC(Random rnd, int X, int Y)
        {
            this.AttackXp = rnd.Next(10, 500) * (X + 1) * (Y + 1);
            this.StrengthXp = rnd.Next(10, 500) * (X + 1) * (Y + 1);
            this.HitpointsXp = rnd.Next(10, 500) * (X + 1) * (Y + 1);
            this.Hitpoints = this.getLevel(HitpointsXp);
            this.DefenceXp = rnd.Next(10, 500) * (X + 1) * (Y + 1);
        }
        public void fight(Player player)
        {
            int playerDmg = player.getLevel(player.StrengthXp);
            this.Hitpoints -= playerDmg;
            player.AttackXp += playerDmg * 4;
            player.DefenceXp += playerDmg * 4;
            player.StrengthXp += playerDmg * 4;
            player.HitpointsXp += playerDmg * 2;
            if (this.Hitpoints < 0)
            {
                this.Hitpoints = 0;
            }
            Console.WriteLine(this.Name + " lost " + player.getLevel(player.StrengthXp)+ " hitpoints. Now he has "
                +this.Hitpoints + "hitpoints");
            player.Hitpoints -= this.getLevel(this.AttackXp);
            if (player.Hitpoints < 0)
            {
                player.Hitpoints = 0;
            }
            Console.WriteLine(player.Name + " lost " + this.getLevel(this.StrengthXp) + " hitpoints. Now he has "
                + player.Hitpoints + "hitpoints");
        }
    }

}
