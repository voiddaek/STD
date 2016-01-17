using Otter;
using STD.Components.Weapons;
using STD.Entities.Interface;
using System.Collections.Generic;

namespace STD.Entities.Towers
{
    public class ToCloserEnemyWeaponTower : ITower
    {
        public ToCloserEnemyWeaponTower(IList<IEnemy> enemies, float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Weapon = new ToCloserEnemyWeapon(enemies);
            Sprite = new Spritemap<string>(Resources.Img.Towers.TOWER, 32, 40);
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Sprite.Add("standDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Play("standDown");
            AddComponents(Weapon);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
