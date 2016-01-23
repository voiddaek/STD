using Otter;
using STD;
using STD.Entities.Towers;
using STD.Components;
using System.Collections.Generic;
using System.Linq;
using STD.Entities.Enemies;

namespace STD.Scenes
{
    public class FirstScene : Scene
    {
        public Music MainSong = new Music(Resources.Music.MAIN_MUSIC, true);

        public FirstScene()
        {
            Global.GAME.Debugger.ShowPerformance(5);
            var background = new Image(Resources.Img.BACKGROUND);
            background.Repeat = true;
            AddGraphic(background);
            Add(new ToCloserEnemyWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Add(new ToCloserEnemyWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Add(new ToCloserEnemyWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Add(new ToCloserEnemyWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Add(new ToCloserEnemyWeaponTower(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            MainSong.Play();
        }

        public override void Update()
        {
            base.Update();
            var enemies = GetEntities<Enemy>();
            for (int i = enemies.Count; i < 30; ++i)
                Add(new Enemy1Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
        }
    }
}
