using Otter;
using STD.Entities;
using STD.Entities.Interface;
using STD.Components;
using STD.Components.Interface;

namespace STD.Components
{
    public class BasicWeapon : IWeapon
    {
        public BasicWeapon() : base(50)
        {
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Shoot()
        {
            Scene.Add(new StraightMovementBullet(new Vector2(Entity.X, Entity.Y), new Vector2(Entity.Input.MouseX - Entity.X, Entity.Input.MouseY - Entity.Y)));
            base.Shoot();
        }
    }
}