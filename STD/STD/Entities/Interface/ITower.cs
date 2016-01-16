using Otter;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities.Interface
{
    public abstract class ITower : Entity
    {
        public Spritemap<string> Sprite;
        public IWeapon Weapon;

        public ITower(IWeapon w, Spritemap<string> s, float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Weapon = w;
            Sprite = s;
            Graphic = Sprite;
            Graphic.CenterOrigin();
            AddComponents(Weapon);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
