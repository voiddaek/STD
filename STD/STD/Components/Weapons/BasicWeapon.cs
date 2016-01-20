using Otter;
using STD.Entities;
using STD.Entities.Bullets;
using STD.Components;

namespace STD.Components.Weapons
{
    public class BasicWeapon : IWeapon
    {
        public BasicWeapon() : base(40)
        {
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
            Scene.Add(new StraightMovementBullet(new Vector2(Entity.X, Entity.Y), new Vector2(Entity.Input.MouseX - Entity.X, Entity.Input.MouseY - Entity.Y)));
            Reset();
        }
    }
}