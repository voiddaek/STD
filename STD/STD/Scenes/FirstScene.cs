﻿using Otter;
using STD;
using STD.Entities;
using STD.Components;
using System.Collections.Generic;
using STD.Entities.Interface;
using System.Linq;

namespace STD.Scenes
{
    public class FirstScene : Scene
    {
        public Music MainSong = new Music(Resources.Music.MAIN_MUSIC, true);
        public IList<ITower> Towers = new List<ITower>();
        public IList<IEnemy> Enemies = new List<IEnemy>();

        public FirstScene()
        {
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new BasicWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            foreach (var tower in Towers)
                Add(tower);
            foreach (var enemy in Enemies)
                Add(enemy);
            MainSong.Play();
        }

        public override void Update()
        {
            base.Update();
            Global.GAME.Debugger.Log(Rand.Float(Width));
            test();
        }

        void test()
        {
            foreach (var enemy in Enemies.Where(x => x.IsDead).ToList())
                Enemies.Remove(enemy);
            if (Enemies.Count < 10)
            {
                IEnemy enemy = new BasicEnemy(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                Enemies.Add(enemy);
                Add(enemy);
            }
        }
    }
}
