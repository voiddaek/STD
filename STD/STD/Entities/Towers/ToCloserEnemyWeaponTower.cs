using Otter;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Enemies;
using System.Collections.Generic;

namespace STD.Entities.Towers
{
    public class ToCloserEnemyWeaponTower : Tower
    {
        public ToCloserEnemyWeaponTower(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Sprite = new Spritemap<string>(Resources.Img.Towers.TOWER_1_1, 40, 40);
            Graphic = Sprite;
            Graphic.CenterOrigin();
            AddComponents(new ToCloserEnemyWeapon(this));
            AddComponent(new Rotation(this, 180));
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
