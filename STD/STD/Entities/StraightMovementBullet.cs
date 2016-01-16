using Otter;
using STD.Components;
using STD.Components.Interface;
using STD.Entities;
using STD.Entities.Interface;

namespace STD.Entities
{
    public class StraightMovementBullet : IBullet
    {
        public StraightMovementBullet(Vector2 position, Vector2 direction) 
            : base(new StraightMovement(direction), new Image(Resources.Img.Towers.TOWER_BULLET))
        {
            X = position.X;
            Y = position.Y;
            LifeSpan = 60;
            Damage = 10;
            SetHitbox(16, 14, 1);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
