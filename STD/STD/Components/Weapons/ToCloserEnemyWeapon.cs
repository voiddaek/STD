using Otter;
using STD.Entities.Bullets;
using STD.Entities.Enemies;
using System.Collections.Generic;
using System.Linq;


namespace STD.Components.Weapons
{
    public class ToCloserEnemyWeapon : IWeapon
    {
        public IList<Enemy> Enemies;

        public ToCloserEnemyWeapon(IList<Enemy> enemies)
            : base(40)
        {
            Range = 300;
            Enemies = enemies;
        }

        public override void Update()
        {
            base.Update();
            if (AtMax)
                Shoot();
        }

        public override void Shoot()
        {
            base.Shoot();
            var enemy = Enemies.Aggregate((i1, i2) => Vector2.Distance(new Vector2(i1.X, i1.Y), new Vector2(Entity.X, Entity.Y)) < Vector2.Distance(new Vector2(i2.X, i2.Y), new Vector2(Entity.X, Entity.Y)) ? i1 : i2 );
            var distance = Vector2.Distance(new Vector2(enemy.X, enemy.Y), new Vector2(Entity.X, Entity.Y));
            if (enemy != null && distance < Range)
            {
                Scene.Add(new EnemyTargetBullet(new Vector2(Entity.X, Entity.Y), enemy));
                Reset();
            }
        }
    }
}