using Otter;

namespace STD.Particles
{
    public class EnemyExplosionParticle : IParticle
    {
        public EnemyExplosionParticle(float x, float y)
            : base(x, y)
        {
            EndFrame = 23;
            Sprite = new Spritemap<string>(Resources.Img.Enemies.ENEMY_EXPLOSION, 130, 130);
            Sprite.Add("explode", new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, new float[] { 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f, 0.1f }).NoRepeat();
            Sprite.Play("explode");
            Graphic = Sprite;
            Graphic.CenterOrigin();
        }
    }
}