using Otter;

namespace STD.Components.Movements
{
    public class StraightMovement : Movement
    {
        public Vector2 Direction;
        public int Speed;
        public StraightMovement(int speed, Vector2 direction)
        {
            Speed = speed;
            Direction.Normalize(Speed);
        }

        public override void Update()
        {
            base.Update();
            MoveXY((int)(Direction.X), (int)(Direction.Y));
        }
    }
}
