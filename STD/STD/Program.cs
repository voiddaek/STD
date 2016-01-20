using Otter;
using STD;
using STD.Scenes;
using System;

namespace STD
{
    class Vector
    {
        public Vector2 Value;

        public Vector(Vector2 value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class TestClass
    {
        Vector _a, _b, _c, _d;

        public TestClass(Vector a, Vector b, Vector c, Vector d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public void Work()
        {
            _a.Value.X = 20;
            _b.Value.X = 222;
            _c.Value.X = 333;
            _d.Value.X = 444;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vector a = new Vector(new Vector2(0, 1)), b = new Vector(new Vector2(0, 1)), c = new Vector(new Vector2(0, 1)), d = new Vector(new Vector2(0, 1));
            Console.WriteLine("a: {0}, b: {1}, c: {2}, d: {3}", a, b, c, d);
            new TestClass(a, b, c, d).Work();
            Console.WriteLine("a: {0}, b: {1}, c: {2}, d: {3}", a, b, c, d);
            a.Value.X = 200;
            Console.WriteLine("a: {0}, b: {1}, c: {2}, d: {3}", a, b, c, d);
            // Create a Game.
            Global.GAME = new Game(Global.NAME, Global.WIDTH, Global.HEIGHT, Global.FPS, false);
            Global.PlayerSession = Global.GAME.AddSession("Player");
            Global.PlayerSession.Controller.AddButton(Key.Return);
            Global.PlayerSession.Controller.Button(Key.Return).AddKey(Key.Return);
            Global.PlayerSession.Controller.AddButton("Left");
            Global.PlayerSession.Controller.Button("Left").AddKey(Key.Left);
            Global.PlayerSession.Controller.Button("Left").AddMouseButton(MouseButton.Left);
            Global.PlayerSession.Controller.AddButton("Right");
            Global.PlayerSession.Controller.Button("Right").AddKey(Key.Right);
            Global.PlayerSession.Controller.Button("Right").AddMouseButton(MouseButton.Right);
            Global.GAME.FirstScene = new IntroScene();

            Global.GAME.Debugger.ToggleKey = Key.F4;
            Global.GAME.Start();
        }

        [OtterCommand(helpText: "Change the color of the game.", group: "game")]
        static void GameColor(string color)
        {
            // Set the game's color to the color from the command.
            Game.Instance.Color = new Color(color);
        }
    }
}