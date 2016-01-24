using Otter;
using STD.Entities.Turrets;
using System;

namespace STD.Components.Weapons
{
    public abstract class Weapon : AutoTimer
    {
        public Turret Tower;
        public float Range;
        public Sound ShootSound;

        public Weapon(float cooldown) : base(cooldown)
        {
            this.Start();
        }

        public override void Update()
        {
            base.Update();
        }

        public virtual void Shoot()
        {
        }
    }
}