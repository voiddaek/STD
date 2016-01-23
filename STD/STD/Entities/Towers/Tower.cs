using Otter;
using STD.Components.Weapons;
using STD.Entities.Common;

namespace STD.Entities.Towers
{
    public abstract class Tower : EntityWithDirection
    {
        public Spritemap<string> Sprite;

        public Tower()
        {
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
