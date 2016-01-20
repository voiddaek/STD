using Otter;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Bullets;
using STD.Entities.Enemies;

namespace STD.Entities.Bullets
{
    public class StraightMovementBullet : IBullet
    {
        public StraightMovementBullet(Vector2 position, Vector2 direction)
        {
            X = position.X;
            Y = position.Y;
            BulletImage = new Spritemap<string>(Resources.Img.Towers.TOWER_BULLET, 16, 14);
            Movement = new StraightMovement(1000, direction);
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
            var collb = Collider.Collide(X, Y, Global.HitBoxTag.Enemy);
            if (collb != null)
            {
                IEnemy enemy = (IEnemy)collb.Entity;
                enemy.Hurt(Damage);
                RemoveSelf();
            }
        }
    }
}
