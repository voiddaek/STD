using Otter;
using STD.Entities.Common;
using System.Collections.Generic;

namespace STD.Components.Movements
{
    public class CheckPointMovement : EntityMovement
    {
        public LinkedListNode<Vector2> CheckPoints;
        public CheckPointMovement(EntityWithDirection entity, LinkedListNode<Vector2> checkPoints)
        {
            EntityWithDirection = entity;
            CheckPoints = checkPoints;
        }

        public override void Update()
        {
            base.Update();
            EntityWithDirection.Direction.X = CheckPoints.Value.X - Entity.X;
            EntityWithDirection.Direction.Y = CheckPoints.Value.Y - Entity.Y;
            EntityWithDirection.Direction.Normalize(EntityWithDirection.Speed);
            MoveXY((int)EntityWithDirection.Direction.X, (int)EntityWithDirection.Direction.Y);
            var distance = Vector2.Distance(CheckPoints.Value, new Vector2(Entity.X, Entity.Y));
            if (distance <= EntityWithDirection.Speed / SpeedScale)
                CheckPoints = CheckPoints.NextOrFirst();
        }
    }
}
