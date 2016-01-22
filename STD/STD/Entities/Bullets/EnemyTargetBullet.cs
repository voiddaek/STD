using Otter;
using STD.Particles;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Enemies;

namespace STD.Entities.Bullets
{
    public class EnemyTargetBullet : Bullet
    {
        private int _distance = 0;

        public EnemyTargetBullet(Vector2 position, Enemy target)
        {
            X = position.X;
            Y = position.Y;
            Speed = 3000;
            BulletImage = new Spritemap<string>(Resources.Img.Towers.TOWER_BULLET, 16, 14);
            Damage = 4;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(new ToEnemyMovement(this, target));
            SetHitbox(1, 1, Global.HitBoxTag.Bullet);
        }

        public override void Update()
        {
            base.Update();
            var collb = Collider.Collide(X, Y, Global.HitBoxTag.Enemy);
            if (collb != null)
            {
                Enemy enemy = (Enemy)collb.Entity;
                enemy.Hurt(Damage);
                Scene.Add(new BasicBulletExplosionParticle(X, Y));
                RemoveSelf();
            }
            _distance += Speed;
            if (_distance % (Speed * 6) == 0)
                Scene.Add(new BasicBulletTrailParticle(X, Y));
        }
    }
}
