using Otter;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Components.Movements
{
    public class ToEnemyMovement : IMovement
    {
        public IEnemy Target;

        public ToEnemyMovement(float speed, IEnemy enemy)
        {
            Target = enemy;
            Speed = speed;
        }

        public override void Update()
        {
            base.Update();
            if (Target.IsDead)
                Entity.RemoveSelf();
            Direction.X = Target.X - Entity.X;
            Direction.Y = Target.Y - Entity.Y;
            Direction.Normalize(Speed);
            Entity.AddPosition(Direction);
        }
    }
}
