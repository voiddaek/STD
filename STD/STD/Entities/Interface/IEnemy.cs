using Otter;
using STD.Components;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities.Interface
{
    public abstract class IEnemy : Entity
    {
        public Spritemap<string> Sprite;
        public Sound HurtSound;
        public Life Health;
        public IMovement Movement;
        public float Speed;
        public bool IsDead { get { return Health.Health <= 0; } }

        public IEnemy()
        {
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
