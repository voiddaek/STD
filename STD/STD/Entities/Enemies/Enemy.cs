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

        public Enemy()
        {
            Layer = (int)Global.LayerPriority.Enemy;
        }

        public virtual void Hurt(int damage)
        {
        }

        public bool IsDead
        {
            get { return Health.IsDead; }
        }
    }
}
