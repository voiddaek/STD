using Otter;
using STD.Entities.Bullets;
using STD.Entities.Monsters;
using STD.Entities.Turrets;
using STD.Events;
using System.Collections.Generic;
using System.Linq;


namespace STD.Components.Weapons
{
    public class AoEWeapon : Weapon
    {
        public Image RangeImage;
        IList<Monster> Targets;
        public AoEWeapon(Turret tower)
            : base(range:tower.Range, damage:1, cooldown: 13)
        {
            ShootSound = new Sound(Resources.Sound.Monsters.BASIC_ENEMY_SHOOT);
            ShootSound.Volume = 0.2f;
            Tower = tower;
            Range = 100;
            RangeImage = Image.CreateCircle(100, new Color(0x25456320));
            RangeImage.CenterOrigin();
            Tower.AddGraphic(RangeImage);
        }

        public override void Update()
        {
            base.Update();
            var enemies = Scene.GetEntities<Monster>();
            if (enemies.IsEmpty())
                return;
            Targets = enemies.Where(x => Vector2.Distance(new Vector2(x.X, x.Y), new Vector2(Entity.X, Entity.Y)) <= Range).Take(Tower.MaxTargets).ToList();
            if (AtMax)
                Shoot();
        }

        public override void Shoot()
        {
            base.Shoot();
            foreach (var target in Targets)
                target.PushEvent(new DamageMonsterEvent(target, Damage));
            ShootSound.Play();
            Reset();
        }
    }
}