using Otter;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Monsters;
using System.Collections.Generic;

namespace STD.Entities.Turrets
{
    public class ToCloserMonsterWeaponTurret : Turret
    {
        public ToCloserMonsterWeaponTurret(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Sprite = new Spritemap<string>(Resources.Sprites.Turrets.TOWER_1_1, 40, 40);
            Graphic = Sprite;
            Graphic.CenterOrigin();
            AddComponents(new ToCloserMonsterWeapon(this));
            AddComponent(new Rotation(this, 180));
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
