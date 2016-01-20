using Otter;
using STD.Particles;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Enemies;

namespace STD.Entities.Bullets
{
    public class EnemyTargetBullet : IBullet
    {
        private int _distance = 0;

        public EnemyTargetBullet(Vector2 position, IEnemy target)
        {
            X = position.X;
            Y = position.Y;
            Speed = 3000;
            BulletImage = new Spritemap<string>(Resources.Img.Towers.TOWER_BULLET, 16, 14);
            Movement = new ToEnemyMovement(Speed, target);
            Damage = 4;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(Movement);
            SetHitbox(1, 1, Global.HitBoxTag.Bullet);
        }

        public override void Update()
        {
            base.Update();
            var collb = Collider.Collide(X, Y, Global.HitBoxTag.Enemy);
            if (collb != null)
            {
                IEnemy enemy = (IEnemy)collb.Entity;
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
