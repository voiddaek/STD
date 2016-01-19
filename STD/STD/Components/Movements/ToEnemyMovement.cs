using Otter;
using STD.Entities.Enemies;

namespace STD.Components.Movements
{
    public class ToEnemyMovement : Movement
    {
        public IEnemy Target;
        public int Speed;
        public Vector2 Direction;
        public ToEnemyMovement(int speed, IEnemy enemy)
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
            MoveXY((int)(Direction.X), (int)(Direction.Y));
        }
    }
}
