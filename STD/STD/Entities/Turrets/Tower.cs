using Otter;
using STD.Components.Weapons;
using STD.Entities.Common;

namespace STD.Entities.Turrets
{
    public abstract class Turret : EntityWithDirection
    {
        public Spritemap<string> Sprite;
        public float Range;
        public int MaxTargets;
        public Turret(float range, int maxtargets = 1)
            : base(baseSpeed: 0)
        {
            MaxTargets = maxtargets;
            Range = range;
            Layer = (int)Global.LayerPriority.Turret;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}