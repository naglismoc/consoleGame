using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class GameMechanics
    {
        public static void walk(Player player, int Y, int X, char[][] terrain)
        {
            Console.WriteLine("go north - N, go south - S, go east - E, go west - W.");
            Console.WriteLine(player.Name + " what will you do?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "n":
                    Console.WriteLine("You went North");
                    Y--;
                    break;
                case "s":
                    Console.WriteLine("You went South");
                    Y++;
                    break;
                case "e":
                    Console.WriteLine("You went East");
                    X++;
                    break;
                case "w":
                    Console.WriteLine("You went West");
                    X--;
                    break;
                default:
                    Console.WriteLine("unknown command");
                    break;
            }
            terrain[Y][X] = Char.ToUpper(terrain[Y][X]);
        }
        public static void encounter(NPC NPC, Player player, int X, int Y)
        {
            Console.WriteLine("You just met an enemy!" + NPC);
            Console.WriteLine(NPC.Name + " is " + NPC.Level() + " lvl.");
            Console.WriteLine(player.Name + " What will you do? R for run, A for attack.");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "a":
                    fight(NPC, player,  X,  Y);
                    break;
                case "r":
                    Console.WriteLine("You ran away");
                    break;
                default:
                    Console.WriteLine("unknown command");
                    break;
            }
        }
        public static void fight(NPC NPC, Player player, int X, int Y)
        {
            bool fight = true;
            while (fight)
            {
                NPC.fight(player);
                if (NPC.Hitpoints == 0)
                {
                    Console.WriteLine("You won the fight");
                    fight = false;
                    Console.WriteLine(player);
                    player.Hitpoints = player.getLevel(player.HitpointsXp);
                }
                if (player.Hitpoints == 0)
                {
                    Console.WriteLine("Oh dear, you died!");
                    fight = false;
                    player.Hitpoints = player.getLevel(player.HitpointsXp);
                    X = 0;
                    Y = 0;
                }
            }
        }
        public static NPC meetEnemy(Random rnd, int X, int Y)
        {
            int randomNr = rnd.Next(0, 2);
            if (randomNr == 0)
            {
                return new Goblin(rnd, X, Y);
            }
            if (randomNr == 1)
            {
                return new Elf(rnd, X, Y);
            }

            return new NPC(rnd, X, Y);
        }

        public static char[][] generateTerrain(Random rnd)
        {
            char[][] terrain = new char[25][];
            char[] landTypes = new char[4] { 'm', 'c', 'f', 'd' };

            for (int i = 0; i < terrain.Length; i++)
            {
                char[] row = new char[25];
                for (int a = 0; a < row.Length; a++)
                {
                    row[a] = landTypes[rnd.Next(0, 4)];
                }
                terrain[i] = row;
            }
            terrain[0][0] = 'C';
            return terrain;
        }

        public static void printTerrain(char[][] terrain)
        {
            for (int i = 0; i < terrain.Length; i++)
            {
                for (int a = 0; a < terrain[i].Length; a++)
                {
                    if (char.IsUpper(terrain[i][a]))
                    {
                        Console.Write("[" + terrain[i][a] + "]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
