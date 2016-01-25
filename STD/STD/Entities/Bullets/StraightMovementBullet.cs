using Otter;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Bullets;
using STD.Entities.Monsters;

namespace STD.Entities.Bullets
{
    public class StraightMovementBullet : Bullet
    {
        public StraightMovementBullet(Vector2 position, Vector2 direction) : base(damage:4, baseSpeed:1000)
        {
            X = position.X;
            Y = position.Y;
            BulletImage = new Spritemap<string>(Resources.Sprites.Bullets.BULLET_GREEN_1_1, 12, 12);
            LifeSpan = 60;
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
                Monster enemy = (Monster)collb.Entity;
                enemy.Hurt(Damage);
                RemoveSelf();
            }
        }
    }
}
