using Otter;
using STD.Entities.Common;

namespace STD.Entities.Bullets
{
    public abstract class Bullet : EntityWithDirection
    {
        public Spritemap<string> BulletImage;
        public int Damage;

        public Bullet(int damage, int baseSpeed) : base(baseSpeed)
        {
            Damage = damage;
            Layer = (int)Global.LayerPriority.Bullet;
        }
    }
}
