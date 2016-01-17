using Otter;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities.Interface
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
