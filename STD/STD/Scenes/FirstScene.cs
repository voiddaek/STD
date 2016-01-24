using Otter;
using STD;
using STD.Entities.Turrets;
using STD.Components;
using System.Collections.Generic;
using System.Linq;
using STD.Entities.Monsters;
using STD.Entities;

namespace STD.Scenes
{
    public class FirstScene : Scene
    {
        public Music MainSong = new Music(Resources.Music.MAIN_MUSIC, true);

        public FirstScene()
        {
            Global.GAME.Debugger.ShowPerformance(5);
            var background = new Image(Resources.Sprites.BACKGROUND);
            background.Repeat = true;
            AddGraphic(background);
            Add(new Map());
            Add(new ToCloserMonsterWeaponTurret(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Add(new ToCloserMonsterWeaponTurret(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Add(new ToCloserMonsterWeaponTurret(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Add(new ToCloserMonsterWeaponTurret(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Add(new ToCloserMonsterWeaponTurret(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            MainSong.Play();
        }

        public override void Update()
        {
            base.Update();
            var enemies = GetEntities<Monster>();
            for (int i = enemies.Count; i < 1; ++i)
                Add(new Monster1Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
        }
    }
}
