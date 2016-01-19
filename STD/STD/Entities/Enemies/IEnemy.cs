using Otter;
using STD.Components;
using STD.Entities;

namespace STD.Entities.Enemies
{
    public abstract class IEnemy : Entity
    {
        public Spritemap<string> Sprite;
        public Sound HurtSound;
        public Life Health;
        public Movement Movement;
        public int Speed;
        public bool IsDead { get { return Health.Health <= 0; } }

        public IEnemy()
        {
        }

        public override void Update()
        {
            base.Update();
        }

        public virtual void Hurt(int damage)
        {
        }
    }
}
