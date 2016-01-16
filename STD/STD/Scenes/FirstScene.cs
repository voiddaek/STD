using Otter;
using STD;
using STD.Entities;
using STD.Components;
using System.Collections.Generic;
using STD.Entities.Interface;

namespace STD.Scenes
{
    public class FirstScene : Scene
    {
        public Music MainSong = new Music(Resources.Music.MAIN_MUSIC, true);
        public IList<ITower> Towers = new List<ITower>();

        public FirstScene()
        {
            Towers.Add(new BasicWeaponTower(50, 50));
            Towers.Add(new BasicWeaponTower(100, 170));
            Towers.Add(new BasicWeaponTower(200, 600));
            Towers.Add(new BasicWeaponTower(300, 240));
            Towers.Add(new BasicWeaponTower(400, 475));
            Towers.Add(new BasicWeaponTower(500, 125));
            Towers.Add(new BasicWeaponTower(550, 500));
            foreach (var tower in Towers)
                Add(tower);
            MainSong.Play();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
