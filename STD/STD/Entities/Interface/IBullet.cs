using Otter;
using STD.Components.Interface;

namespace STD.Entities.Interface
{
    public abstract class IBullet : Entity
    {
        public Image BulletImage;
        public IMovement Movement;
        public float Damage;

        public IBullet(IMovement movement, Image image)
        {
            Movement = movement;
            BulletImage = image;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(Movement);
        }

        public virtual void Destroy()
        {
            RemoveSelf();
        }
    }
}
