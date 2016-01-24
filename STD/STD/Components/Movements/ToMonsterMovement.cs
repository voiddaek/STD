using Otter;
using STD.Entities.Common;
using STD.Entities.Monsters;

namespace STD.Components.Movements
{
    public class ToMonsterMovement : EntityMovement
    {
        public Monster Target;
        public ToMonsterMovement(EntityWithDirection entity, Monster target)
        {
            Target = target;
            EntityWithDirection = entity;
        }

        public override void Update()
        {
            base.Update();
            if (Target.IsDead)
                Entity.RemoveSelf();
            EntityWithDirection.Direction.X = Target.X - Entity.X;
            EntityWithDirection.Direction.Y = Target.Y - Entity.Y;
            EntityWithDirection.Direction.Normalize(EntityWithDirection.Speed);
            MoveXY((int)(EntityWithDirection.Direction.X), (int)(EntityWithDirection.Direction.Y));
        }
    }
}
