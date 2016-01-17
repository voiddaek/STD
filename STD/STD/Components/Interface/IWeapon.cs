using Otter;
using System;

namespace STD.Components.Interface
{
    public abstract class IWeapon : AutoTimer
    {
        public float Range;

        public IWeapon(float cooldown) : base(cooldown)
        {
            this.Start();
        }

        public override void Update()
        {
            base.Update();
        }

        public virtual void Shoot()
        {
            Reset();
        }
    }
}