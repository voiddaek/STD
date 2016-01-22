using Otter;
using STD.Entities.Common;
using System;

namespace STD.Components.Movements
{
    public class Rotation : EntityMovement
    {
        public float DefaultAngle;
        public Rotation(EntityWithDirection entity, float defaultAngle = 0)
        {
            EntityWithDirection = entity;
            DefaultAngle = defaultAngle;
        }

        public override void Update()
        {
            base.Update();
            Entity.Graphic.Angle = (float)MathHelper.ToDegrees((float)Math.Atan2(EntityWithDirection.Direction.X, EntityWithDirection.Direction.Y)) - DefaultAngle;
        }
    }
}
