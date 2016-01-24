using Otter;
using STD.Components;
using STD.Entities.Common;
using STD.Events;

namespace STD.Entities.Monsters
{
    public abstract class Monster : EntityWithDirection
    {
        public Spritemap<string> Sprite;
        public Sound HurtSound;
        public Sound DeathSound;
        public Life Health;

        public Monster(int baseSpeed)
            : base(baseSpeed: baseSpeed)
        {
            Layer = (int)Global.LayerPriority.Monster;
            AddComponent(new MonsterEventManager());
        }

        public virtual void PushEvent(MonsterEvent monsterEvent)
        {
            GetComponent<MonsterEventManager>().Push(monsterEvent);
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
