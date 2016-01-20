using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using STD;

namespace STD.Components.Movements
{
    public class CheckPointMovement : Movement
    {
        public int Speed;
        public Vector2 Direction;
        public LinkedListNode<Vector2> CheckPoints;
        public CheckPointMovement(int speed, LinkedListNode<Vector2> checkPoints)
        {
            CheckPoints = checkPoints;
            Speed = speed;
        }

        public override void Update()
        {
            base.Update();
            Direction.X = CheckPoints.Value.X - Entity.X;
            Direction.Y = CheckPoints.Value.Y - Entity.Y;
            Entity.Graphic.Angle = (float)MathHelper.ToDegrees((float)Math.Atan2(-Direction.X, Speed / SpeedScale - Direction.Y) + (float)Math.PI / 2);
            Direction.Normalize(Speed);
            MoveXY((int)Direction.X, (int)Direction.Y);
            var distance = Vector2.Distance(CheckPoints.Value, new Vector2(Entity.X, Entity.Y));
            if (distance <= Speed / SpeedScale)
                CheckPoints = CheckPoints.NextOrFirst();
        }
    }
}
