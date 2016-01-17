using Otter;
using STD.Components.Movements;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities.Bullets
{
    public class StraightMovementBullet : IBullet
    {
        public StraightMovementBullet(Vector2 position, Vector2 direction)
        {
            X = position.X;
            Y = position.Y;
            BulletImage = new Spritemap<string>(Resources.Img.Towers.TOWER_BULLET, 16, 14);
            Movement = new StraightMovement(10, direction);
            LifeSpan = 60;
            Damage = 4;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(Movement);
            SetHitbox(16, 14, Global.HitBoxTag.Bullet);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
