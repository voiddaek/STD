using Otter;

namespace STD.Components.Interface
{
    public abstract class IMovement : Component
    {
        // The velocity to move the Entity each frame.
        public Vector2 Direction;
        public float Speed;

        public IMovement()
        {
        }

        public override void Update()
        {
            base.Update();
        }
    }
}