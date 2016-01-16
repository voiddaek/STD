using Otter;

namespace STD.Components.Interface
{
    public abstract class IMovement : Component
    {
        // The velocity to move the Entity each frame.
        public  Vector2 Direction;
        private float Speed;

        public IMovement(Vector2 direction, float speed)
        {
            Direction = direction;
            Speed = speed;
        }

        public override void Update()
        {
            base.Update();
            Direction.Normalize(Speed);
            Entity.AddPosition(Direction);
        }
    }
}