using Otter;
using STD.Particles;
using STD.Components.Movements;
using STD.Components.Weapons;
using STD.Entities.Monsters;
using STD.Events;

namespace STD.Entities.Bullets
{
    public class MonsterTargetBullet : Bullet
    {
        private int _distance = 0;

        public MonsterTargetBullet(Vector2 position, Monster target) : base(baseSpeed:3000)
        {
            X = position.X;
            Y = position.Y;
            BulletImage = new Spritemap<string>(Resources.Sprites.Bullets.BULLET_RED_1_1, 12, 12);
            Damage = 4;
            Graphic = BulletImage;
            Graphic.CenterOrigin();
            AddComponent(new ToMonsterMovement(this, target));
            SetHitbox(1, 1, Global.HitBoxTag.Bullet);
        }

        public override void Update()
        {
            base.Update();
            var collb = Collider.Collide(X, Y, Global.HitBoxTag.Enemy);
            if (collb != null)
            {
                Monster enemy = (Monster)collb.Entity;
                enemy.PushEvent(new SlowMonsterEvent(enemy, 0.5f));
                enemy.PushEvent(new DamageMonsterEvent(enemy, Damage));
                Scene.Add(new BasicBulletExplosionParticle(X, Y));
                RemoveSelf();
            }
            _distance += Speed;
            if (_distance % (Speed * 6) == 0)
                Scene.Add(new BasicBulletTrailParticle(X, Y));
        }
    }
}
