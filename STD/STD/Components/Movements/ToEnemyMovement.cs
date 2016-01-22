using Otter;
using STD.Entities.Common;
using STD.Entities.Enemies;

namespace STD.Components.Movements
{
    public class ToEnemyMovement : EntityMovement
    {
        public Enemy Target;
        public ToEnemyMovement(EntityWithDirection entity, Enemy enemy)
        {
            Target = enemy;
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
