using Otter;
using STD.Components.Weapons;
using STD.Entities.Common;

namespace STD.Entities.Turrets
{
    public abstract class Turret : EntityWithDirection
    {
        public Spritemap<string> Sprite;

        public Turret()
            : base(baseSpeed: 0)
        {
            Layer = (int)Global.LayerPriority.Turret;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}