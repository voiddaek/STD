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
            Sprite = new Spritemap<string>(Resources.Img.Towers.TOWER, 32, 40);
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Sprite.Add("standDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Play("standDown");
            AddComponents(new ToCloserEnemyWeapon(this));
            AddComponent(new Rotation(this));
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
