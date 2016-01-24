using Otter;
using STD.Entities.Common;

namespace STD.Entities.Bullets
{
    public abstract class Bullet : EntityWithDirection
    {
        public Spritemap<string> BulletImage;
        public int Damage;

        public Bullet(int baseSpeed) : base(baseSpeed)
        {
            Layer = (int)Global.LayerPriority.Bullet;
        }
    }
}
