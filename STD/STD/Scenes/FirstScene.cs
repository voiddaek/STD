using Otter;
using STD;
using STD.Entities.Towers;
using STD.Entities.Enemies;
using STD.Components;
using System.Collections.Generic;
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
            Global.GAME.Debugger.ShowPerformance(5);
            var background = new Image(Resources.Img.BACKGROUND);
            background.Repeat = true;
            AddGraphic(background);
            Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            //Towers.Add(new ToCloserEnemyWeaponTower(Enemies, Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height)));
            foreach (var tower in Towers)
                Add(tower);
            foreach (var enemy in Enemies)
                Add(enemy);
            MainSong.Play();
        }

        public override void Update()
        {
            base.Update();
            test();
        }

        void test()
        {
            foreach (var enemy in Enemies.Where(x => x.IsDead).ToList())
                Enemies.Remove(enemy);
            if (Enemies.Count < 25)
            {
                //var r = Rand.Int(0, 3);
                //if (r == 0)
                //{
                    IEnemy enemy1 = new Enemy1Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    Enemies.Add(enemy1);
                    Add(enemy1);
                    //IEnemy enemy2 = new Enemy2Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy2);
                    //Add(enemy2);
                    //IEnemy enemy3 = new Enemy3Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy3);
                    //Add(enemy3);
                    ////}
                    ////if (r == 1)
                    ////{
                    //IEnemy enemy2 = new Enemy2Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy2);
                    //Add(enemy2);
                    ////}
                    ////if (r == 2)
                    ////{
                    //IEnemy enemy3 = new Enemy3Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy3);
                    //Add(enemy3);

                    //IEnemy enemy4 = new Enemy1Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy4);
                    //Add(enemy4);

                    //IEnemy enemy5 = new Enemy2Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy5);
                    //Add(enemy5);

                    //IEnemy enemy6 = new Enemy3Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy6);
                    //Add(enemy6);

                    //IEnemy enemy7 = new Enemy3Blue(Rand.Float(Global.GAME.Width), Rand.Float(Global.GAME.Height));
                    //Enemies.Add(enemy7);
                    //Add(enemy7);
                //}
            }
        }
    }
}
