using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a game
            var game = new Game("My First Otter Game", 640, 480, 60, false);

            // Start it up
            game.Start();
        }
    }
}