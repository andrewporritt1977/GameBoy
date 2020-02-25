using GameBoy20.Utils;
using System;

namespace GameBoy20
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select your game, 1,2,3");
            var selection = int.Parse(Console.ReadLine());
            Console.WriteLine("Launching " + selection);
            GameSelection gameSelection = new GameSelection();
            IGame game = gameSelection.SelectGame(selection);
            game.LaunchGame();
        }
    }
}
