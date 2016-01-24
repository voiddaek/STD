using Otter;
namespace STD.Entities.Common
{
    public abstract class EntityWithDirection : Entity
    {
        public Vector2 Direction;
        public int BaseSpeed;
        public int Speed;
        
        public EntityWithDirection(int baseSpeed)
        {
            BaseSpeed = baseSpeed;
            Speed = baseSpeed;
        }
    }
}
