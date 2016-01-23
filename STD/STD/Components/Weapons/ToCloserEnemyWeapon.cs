using Otter;
using STD.Entities.Bullets;
using STD.Entities.Enemies;
using STD.Entities.Towers;
using System.Collections.Generic;
using System.Linq;


namespace STD.Components.Weapons
{
    public class ToCloserEnemyWeapon : Weapon
    {
        public ToCloserEnemyWeapon(Tower tower) : base(40)
        {
            Tower = tower;
            Range = 300;
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
            var enemies = Scene.GetEntities<Enemy>();
            if (enemies.IsEmpty())
                return;
            var enemy = enemies.Aggregate((i1, i2) => Vector2.Distance(new Vector2(i1.X, i1.Y), new Vector2(Entity.X, Entity.Y)) < Vector2.Distance(new Vector2(i2.X, i2.Y), new Vector2(Entity.X, Entity.Y)) ? i1 : i2);
            var distance = Vector2.Distance(new Vector2(enemy.X, enemy.Y), new Vector2(Entity.X, Entity.Y));
            if (enemy != null && distance < Range)
            {
                Tower.Direction.X = enemy.X - Entity.X;
                Tower.Direction.Y = enemy.Y - Entity.Y;
                Scene.Add(new EnemyTargetBullet(new Vector2(Entity.X, Entity.Y), enemy));
                Reset();
            }
        }
    }
}