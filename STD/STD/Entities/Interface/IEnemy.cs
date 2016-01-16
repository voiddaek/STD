using Otter;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities.Interface
{
    public abstract class IEnemy : Entity
    {
        public Spritemap<string> Sprite;
        public float Health;
        public float Speed;
        public bool IsDead { get { return Health <= 0; } }

        public const float MOVE_DISTANCE = 300;
        public bool direction = true;
        public float distMoved = 0f;

        public IEnemy(Spritemap<string> s, float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Sprite = s;
            Graphic = Sprite;
            Graphic.CenterOrigin();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
