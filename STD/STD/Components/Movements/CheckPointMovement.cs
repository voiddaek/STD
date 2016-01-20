using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using STD;

namespace STD.Components.Movements
{
    public class CheckPointMovement : Movement
    {
        public Wrapper<int> Speed;
        public Wrapper<Vector2> Direction;
        public Wrapper<LinkedListNode<Vector2>> CheckPoints;
        public CheckPointMovement(Wrapper<Vector2> direction, Wrapper<int> speed, Wrapper<LinkedListNode<Vector2>> checkPoints)
        {
            Direction = direction;
            CheckPoints = checkPoints;
            Speed = speed;
        }

        public override void Update()
        {
            base.Update();
            Direction.Value.X = CheckPoints.Value.Value.X - Entity.X;
            Direction.Value.Y = CheckPoints.Value.Value.Y - Entity.Y;
            Direction.Value.Normalize(Speed.Value);
            MoveXY((int)Direction.Value.X, (int)Direction.Value.Y);
            var distance = Vector2.Distance(CheckPoints.Value.Value, new Vector2(Entity.X, Entity.Y));
            if (distance <= Speed.Value / SpeedScale)
                CheckPoints.Value = CheckPoints.Value.NextOrFirst();
        }
    }
}
