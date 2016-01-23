using Otter;

namespace STD.Particles
{
    public class Particle : Entity
    {
        public Spritemap<string> Sprite;
        public Sound Sound;
        public int EndFrame;

        public Particle(float x, float y)
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