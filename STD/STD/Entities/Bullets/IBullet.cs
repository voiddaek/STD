using Otter;

namespace STD.Entities.Bullets
{
    public abstract class IBullet : Entity
    {
        public Spritemap<string> BulletImage;
        public Movement Movement;
        public int Speed;
        public int Damage;

        public IBullet()
        {
        }
    }
}
