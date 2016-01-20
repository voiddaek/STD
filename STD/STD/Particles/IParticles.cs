using Otter;

namespace STD.Particles
{
    public class IParticle : Entity
    {
        public Spritemap<string> Sprite;
        public Sound Sound;
        public int EndFrame;

        public IParticle(float x, float y)
            : base(x, y)
        {

        }

        public override void Update()
        {
            base.Update();
            if (Sprite.CurrentFrame == EndFrame)
                RemoveSelf();
        }
    }
}