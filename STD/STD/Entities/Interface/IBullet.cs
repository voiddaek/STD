using Otter;
using STD.Components.Interface;

namespace STD.Entities.Interface
{
    public abstract class IBullet : Entity
    {
        public Spritemap<string> BulletImage;
        public IMovement Movement;
        public int Damage;

        public IBullet()
        {
        }

        public virtual void Destroy()
        {
            RemoveSelf();
        }
    }
}
