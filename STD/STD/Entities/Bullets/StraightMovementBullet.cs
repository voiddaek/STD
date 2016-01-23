using Otter;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Bullets;
using STD.Entities.Enemies;

namespace STD.Entities.Bullets
{
    public class StraightMovementBullet : Bullet
    {
        public StraightMovementBullet(Vector2 position, Vector2 direction)
        {
            X = position.X;
            Y = position.Y;
            BulletImage = new Spritemap<string>(Resources.Img.Bullets.BULLET_GREEN_1_1, 12, 12);
            LifeSpan = 60;
            Damage = 4;
            Speed = 1000;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(new StraightMovement(this));
            SetHitbox(16, 14, Global.HitBoxTag.Bullet);
        }

        public override void Update()
        {
            base.Update();
            var collb = Collider.Collide(X, Y, Global.HitBoxTag.Enemy);
            if (collb != null)
            {
                Enemy enemy = (Enemy)collb.Entity;
                enemy.Hurt(Damage);
                RemoveSelf();
            }
        }
    }
}
