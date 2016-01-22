using Otter;
using STD.Components;
using STD.Entities.Common;

namespace STD.Entities.Enemies
{
    public abstract class Enemy : EntityWithDirection
    {
        public Spritemap<string> Sprite;
        public Sound HurtSound;
        public Life Health;
        public bool IsDead { get { return Health.Health <= 0; } }

        public virtual void Hurt(int damage)
        {
        }
    }
}
