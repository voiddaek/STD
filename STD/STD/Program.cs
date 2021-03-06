﻿using Otter;
using STD;
using STD.Scenes;
using System;

namespace STD
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Global.GAME.MouseVisible = true;
            Global.GAME.Debugger.ToggleKey = Key.F4;
            Global.GAME.Start();
        }

        [OtterCommand(helpText: "Change the color of the game.", group: "game")]
        static void GameColor(string color)
        {
            Game.Instance.Color = new Color(color);
        }
    }
}