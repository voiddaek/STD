using Otter;

namespace STD.Particles
{
    public class BasicBulletExplosionParticle : Particle
    {
        public BasicBulletExplosionParticle(float x, float y)
            : base(x, y)
        {
            EndFrame = 3;
            Sprite = new Spritemap<string>(Resources.Sprites.Turrets.TOWER_BULLET_EXPLOSION, 32, 40);
            Sprite.Add("Emit", new int[] { 0, 1, 2, 3 }, new float[] { 10f, 10f, 10f, 10f }).NoRepeat();
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Sprite.Play("Emit");
        }
    }
}