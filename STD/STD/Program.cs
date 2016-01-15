using Otter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilemapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Game.
            var game = new Game("Tilemap Example");

            // Create a Scene.
            var scene = new Scene();
            // Add the Tiles Entity to the Scene.
            scene.Add(new Tiles());

            // Set the mouse visibility to true for this example.
            game.MouseVisible = true;

            // Start the Game.
            game.Start(scene);
        }
    }

    class Tiles : Entity
    {
        // The Tilemap Graphic to use for rendering tiles.
        public Tilemap Tilemap;
        // The grid size to use for the Tilemap.
        public static int GridSize = 32;
        // The current selected tile to place.
        public int CurrentTile;

        public Tiles()
            : base()
        {
            // Create the Tilemap the size of the game window using the defined grid size.
            Tilemap = new Tilemap(@"img\tiles.png", Game.Instance.Width, Game.Instance.Height, GridSize, GridSize);
            // Add the Tilemap to the list of Graphics to render.
            AddGraphic(Tilemap);

            // Place some tiles.
            Tilemap.SetTile(0, 0, 0);
            Tilemap.SetTile(1, 0, 0);
            Tilemap.SetTile(2, 0, 0);

            // Place some more tiles.
            Tilemap.SetTile(0, 4, 1);
            Tilemap.SetTile(1, 4, 1);
            Tilemap.SetTile(2, 4, 1);

            // Even more tiles.
            Tilemap.SetTile(0, 8, 2);
            Tilemap.SetTile(1, 8, 2);
            Tilemap.SetTile(2, 8, 2);

            // Want more tiles?
            Tilemap.SetTile(0, 12, 3);
            Tilemap.SetTile(1, 12, 3);
            Tilemap.SetTile(2, 12, 3);
        }

        public override void Update()
        {
            base.Update();

            // Determine the grid position of the mouse.
            var gridX = (int)Util.SnapToGrid(Input.MouseX, GridSize) / GridSize;
            var gridY = (int)Util.SnapToGrid(Input.MouseY, GridSize) / GridSize;

            // Switch the current tile to place based on the mouse wheel movement.
            CurrentTile += Input.MouseWheelDelta;
            CurrentTile %= 4; // Make sure the current tile is always 0 to 3.

            if (Input.MouseWheelDelta != 0)
            {
                // Log the current tile value.
                Console.WriteLine("Current Tile is now {0}", CurrentTile);
            }

            // Place a tile when the left mouse button is down.
            if (Input.MouseButtonDown(MouseButton.Left))
            {
                Tilemap.SetTile(gridX, gridY, CurrentTile);
            }
            // Remove a tile when the right mouse button is down.
            if (Input.MouseButtonDown(MouseButton.Right))
            {
                Tilemap.ClearTile(gridX, gridY);
            }
        }
    }
}