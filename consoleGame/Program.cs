using System;

namespace consoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[][] terrain = generateTerrain(rnd);
            Console.WriteLine("===============  WELCOME TO NARNIA ============");
            int X = 0;
            int Y = 0;
            
            while (true)
            {
                printTerrain(terrain);
                Console.WriteLine("go north - N, go south - S, go east - E, go west - W.");
                Console.WriteLine("what will you do?");
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
                if(terrain[Y][X] != 'C' && rnd.Next(0,10) == 0 )
                {
                    Console.WriteLine("You just met an enemy!");
                }
            }
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
