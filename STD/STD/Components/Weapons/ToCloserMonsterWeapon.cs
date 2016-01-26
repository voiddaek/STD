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
        public int MaxTargets;
        IList<Monster> Targets;
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
            var targetsDistance = enemies.Select(x => new { Target = x, Distance = Vector2.Distance(new Vector2(x.X, x.Y), new Vector2(Entity.X, Entity.Y))}).ToList();
            Targets = targetsDistance.OrderBy(x => x.Distance).Select(x => x.Target).Take(Tower.MaxTargets).ToList();
            if (Targets.Any())
            {
                Tower.Direction.X = Targets.Sum(target => target.X) / Targets.Count;
                Tower.Direction.Y = Targets.Sum(target => target.Y) / Targets.Count;
            }
            if (AtMax)
                Shoot();
        }

        public override void Shoot()
        {
            base.Shoot();
            ShootSound.Play();
            foreach (var target in Targets)
                Scene.Add(new MonsterTargetBullet(new Vector2(Entity.X, Entity.Y), target, Damage));
            Reset();
        }
    }
}