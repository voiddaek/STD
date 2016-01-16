using Otter;
using STD.Components;
using STD.Entities;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities
{
    public class BasicWeaponTower : ITower
    {
        public BasicWeaponTower(float x = 0, float y = 0)
            : base(new BasicWeapon(), new Spritemap<string>(Resources.Img.Towers.TOWER, 32, 40), x, y)
        {
            Sprite.Add("standDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Play("standDown");
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
