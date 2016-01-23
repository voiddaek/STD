using Otter;
using STD.Entities.Towers;
using System;

namespace STD.Components.Weapons
{
    public abstract class Weapon : AutoTimer
    {
        public Tower Tower;
        public float Range;

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