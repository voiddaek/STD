﻿using Otter;
using STD;
using STD.Scenes;

namespace TilemapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Game.
            Global.GAME = new Game("STD");
            Global.GAME.SetWindow(800, 600);
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
            Global.GAME.Start();
        }
    }
}