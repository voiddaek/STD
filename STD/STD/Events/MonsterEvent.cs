using Otter;
using STD.Entities.Monsters;
namespace STD.Events
{
    public abstract class MonsterEvent : EventProcessorEvent
    {
        public Monster Monster;
        public MonsterEvent(Monster monster)
        {
            Monster = monster;
        }
    }

    public class SlowMonsterEvent : MonsterEvent
    {
        public float Duration;
        public float Ratio;
        public SlowMonsterEvent(Monster monster, float ratio, float duration) : base(monster)
        {
            Duration = duration;
            Ratio = ratio;
        }

        public override void Begin()
        {
 	        base.Begin();
            Monster.Speed = (int)(Monster.BaseSpeed * Ratio);
        }

        public override void Update()
        {
            base.Update();
            if (Timer > Duration)
                Finish();
        }

        public override void End()
        {
            base.End();
            Monster.Speed = Monster.BaseSpeed;
        }
    }

    public class DamageMonsterEvent : MonsterEvent
    {
        int Damage;
        public DamageMonsterEvent(Monster monster, int damage)
            : base(monster)
        {
            Damage = damage;
        }

        public override void Begin()
        {
            base.Begin();
            Monster.Health.Hurt(Damage);
            Finish();
        }
    }
}
