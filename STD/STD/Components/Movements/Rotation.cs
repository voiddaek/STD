using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using STD;

namespace STD.Components.Movements
{
    public class Rotation : Movement
    {
        public Wrapper<Vector2> Direction;
        public Rotation(Wrapper<Vector2> direction)
        {
            Direction = direction;
        }

        public override void Update()
        {
            base.Update();
            Entity.Graphic.Angle = (float)MathHelper.ToDegrees((float)Math.Atan2(Direction.Value.X, Direction.Value.Y)) - 90;
        }
    }
}
