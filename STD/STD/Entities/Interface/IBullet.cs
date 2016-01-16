using Otter;
using STD.Components.Interface;

namespace STD.Entities.Interface
{
    public abstract class IBullet : Entity
    {
        private Image BulletImage;
        private IMovement Movement;

        public IBullet(IMovement movement, Image image)
        {
            Movement = movement;
            BulletImage = image;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(Movement);
        }
    }
}
