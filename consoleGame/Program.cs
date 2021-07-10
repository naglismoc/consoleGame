using System;

namespace consoleGame
{
    class Program
    {
        static int X = 0;
        static int Y = 0;
        static void Main(string[] args)
        {

            Random rnd = new Random();
            CaveGoblin cg = new CaveGoblin(rnd, 2, 2);
            Console.WriteLine(cg);
            char[][] terrain = GameMechanics.generateTerrain(rnd);
            Console.WriteLine("===============  WELCOME TO NARNIA ============");
            Console.WriteLine("What is yor name?");
            string name = Console.ReadLine();
            Player player = new Player(name);

            while (true)
            {
                GameMechanics.printTerrain(terrain);
                GameMechanics.walk(player,  Y,  X, terrain);
               
                if(terrain[Y][X] != 'C' && rnd.Next(0,2) == 0 )
                {
                    GameMechanics.encounter(GameMechanics.meetEnemy(rnd, X, Y), player, X, Y);
                }
            }
        }
    }
}
