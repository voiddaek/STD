using Otter;

namespace STD.Components.Interface
{
    public abstract class IWeapon : AutoTimer
    {
        public IWeapon(float cooldown) : base(cooldown)
        {
            this.Start();
        }

        public override void Update()
        {
            base.Update();
            if (AtMax)
                Shoot();
        }

        public virtual void Shoot()
        {
            Reset();
        }
    }
}