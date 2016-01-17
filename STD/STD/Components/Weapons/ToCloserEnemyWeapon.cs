using Otter;
using STD.Entities;
using STD.Entities.Bullets;
using STD.Entities.Interface;
using STD.Components;
using STD.Components.Interface;
using System.Collections.Generic;
using System.Linq;
using System;

namespace STD.Components.Weapons
{
    public class ToCloserEnemyWeapon : IWeapon
    {
        public IList<IEnemy> Enemies;

        public ToCloserEnemyWeapon(IList<IEnemy> enemies)
            : base(80)
        {
            Range = 150;
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
            var enemy = Enemies.Where(x => Math.Abs(Math.Pow(x.X - Entity.X, 2) + Math.Pow(x.Y - Entity.Y, 2)) < Range * Range).FirstOrDefault();
            if (enemy != null)
                Scene.Add(new EnemyTargetBullet(new Vector2(Entity.X, Entity.Y), enemy));
        }
    }
}