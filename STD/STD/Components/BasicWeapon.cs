using Otter;
using STD.Entities;
using STD.Entities.Interface;
using STD.Components;
using STD.Components.Interface;

namespace STD.Components
{
    public class BasicWeapon : IWeapon
    {
        public BasicWeapon()
        {
        }

        public override void Update()
        {
            base.Update();
            if (Entity.Input.MouseButtonPressed(MouseButton.Left))
            {
                IBullet bullet = new StraightMovementBullet(new Vector2(Entity.X, Entity.Y), new Vector2(Entity.Input.MouseX - Entity.X, Entity.Input.MouseY - Entity.Y));
                Scene.Add(bullet);
            }
        }
    }
}