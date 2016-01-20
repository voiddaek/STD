using Otter;
using STD.Components.Weapons;

namespace STD.Entities.Towers
{
    public class BasicWeaponTower : ITower
    {
        public BasicWeaponTower(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Weapon = new BasicWeapon();
            Sprite = new Spritemap<string>(Resources.Img.Towers.TOWER, 32, 40);
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Sprite.Add("standDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Play("standDown");
            AddComponents(Weapon);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
