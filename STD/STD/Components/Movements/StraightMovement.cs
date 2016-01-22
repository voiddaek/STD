using Otter;
using STD.Entities.Common;

namespace STD.Components.Movements
{
    public class StraightMovement : EntityMovement
    {

        public StraightMovement(EntityWithDirection entity)
        {
            EntityWithDirection = entity;
        }

        public override void Update()
        {
            base.Update();
            MoveXY((int)(EntityWithDirection.Direction.X), (int)(EntityWithDirection.Direction.Y));
        }
    }
}
