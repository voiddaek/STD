using Otter;
using STD.Components.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using STD;

namespace STD.Components.Movements
{
    public class CheckPointMovement : IMovement
    {
        public LinkedListNode<Vector2> CheckPoints;
        public CheckPointMovement(float speed, LinkedListNode<Vector2> checkPoints)
        {
            CheckPoints = checkPoints;
            Speed = speed;
        }

        public override void Update()
        {
            base.Update();
            Direction.X = CheckPoints.Value.X - Entity.X;
            Direction.Y = CheckPoints.Value.Y - Entity.Y;
            Entity.Graphic.Angle = (float)MathHelper.ToDegrees((float)Math.Atan2(-Direction.X, Speed - Direction.Y) + (float)Math.PI / 2);
            Direction.Normalize(Speed);
            Entity.AddPosition(Direction);
            var D = Vector2.Distance(CheckPoints.Value, new Vector2(Entity.X, Entity.Y));
            if (D <= Speed)
                CheckPoints = CheckPoints.NextOrFirst();
        }
    }
}
