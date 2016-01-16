using Otter;
using STD.Components.Interface;

namespace STD.Components
{
    public class StraightMovement : IMovement
    {
        public StraightMovement(Vector2 direction)
            : base(direction, 10)
        {
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
