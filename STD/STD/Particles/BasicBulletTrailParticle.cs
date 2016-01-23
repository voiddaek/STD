using Otter;

namespace STD.Particles
{
    public class BasicBulletTrailParticle : Particle
    {
        public BasicBulletTrailParticle(float x, float y)
            : base(x, y)
        {
            EndFrame = 3;
            Sprite = new Spritemap<string>(Resources.Img.Towers.TOWER_BULLET_TRAIL, 32, 40);
            Sprite.Add("Emit", new int[] { 0, 1, 2, 3 }, new float[] { 10f, 10f, 10f, 10f }).NoRepeat();
            Sprite.Play("Emit");
            Graphic = Sprite;
            Graphic.CenterOrigin();
        }
    }
}