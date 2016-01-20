using Otter;
using STD.Components.Weapons;

namespace STD.Entities.Towers
{
    public abstract class ITower : Entity
    {
        public Spritemap<string> Sprite;
        public IWeapon Weapon;

        public ITower()
        {
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
