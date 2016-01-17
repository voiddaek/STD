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
            Direction.Normalize(Speed);
            Entity.AddPosition(Direction);
            var distance = Math.Abs(Math.Pow(Entity.X - CheckPoints.Value.X, 2) + Math.Pow(Entity.Y - CheckPoints.Value.Y, 2));
            if (distance <= Speed * Speed)
                CheckPoints = CheckPoints.NextOrFirst();
        }
    }
}
