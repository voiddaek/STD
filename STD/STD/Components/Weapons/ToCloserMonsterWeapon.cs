using Otter;
using STD.Entities.Bullets;
using STD.Entities.Monsters;
using STD.Entities.Turrets;
using System.Collections.Generic;
using System.Linq;


namespace STD.Components.Weapons
{
    public class ToCloserMonsterWeapon : Weapon
    {
        Monster Target;
        public ToCloserMonsterWeapon(Turret tower)
            : base(range:tower.Range, damage:4, cooldown:40)
        {
            ShootSound = new Sound(Resources.Sound.Monsters.BASIC_ENEMY_SHOOT);
            ShootSound.Volume = 0.2f;
            Tower = tower;
        }

        public override void Update()
        {
            base.Update();
            var enemies = Scene.GetEntities<Monster>();
            if (enemies.IsEmpty())
                return;
            Target = enemies.Aggregate((i1, i2) => Vector2.Distance(new Vector2(i1.X, i1.Y), new Vector2(Entity.X, Entity.Y)) < Vector2.Distance(new Vector2(i2.X, i2.Y), new Vector2(Entity.X, Entity.Y)) ? i1 : i2);
            Tower.Direction.X = Target.X - Entity.X;
            Tower.Direction.Y = Target.Y - Entity.Y;
            var distance = Vector2.Distance(new Vector2(Target.X, Target.Y), new Vector2(Entity.X, Entity.Y));
            if (AtMax && distance <= Range)
                Shoot();
        }

        public override void Shoot()
        {
            base.Shoot();
            ShootSound.Play();
            Scene.Add(new MonsterTargetBullet(new Vector2(Entity.X, Entity.Y), Target, Damage));
            Reset();
        }
    }
}