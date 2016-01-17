using Otter;
using STD.Components.Interface;

namespace STD.Components.Movements
{
    public class StraightMovement : IMovement
    {
        public StraightMovement(float speed, Vector2 direction)
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
