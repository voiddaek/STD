using Otter;
using STD.Components;
using STD.Components.Movements;
using STD.Entities.Interface;

namespace STD.Entities.Enemies
{
    public class Enemy3Blue : IEnemy
    {

        public Enemy3Blue(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            HurtSound = new Sound(Resources.Sound.Enemies.BASIC_ENEMY_HURT);
            Sprite = new Spritemap<string>(Resources.Img.Enemies.ENEMY_3_BLUE, 46, 46);
            Sprite.Add("walk", new int[] { 0, 1, 2, 3}, new float[] { 10f, 2f, 2f, 2f});
            Sprite.Play("walk");
            Graphic = Sprite;
            Graphic.CenterOrigin();
            OnDeathSprite = new Spritemap<string>(Resources.Img.Enemies.ENEMY_EXPLOSION, 130, 130);
            OnDeathSprite.Add("explode", new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, new float[] { 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f }).NoRepeat();
            AddGraphic(OnDeathSprite);
            Health = new Life(18);
            Health.OnDeath = OnDeath;
            Health.OnHurt = OnHurt;
            Speed = 1.5f;
            var c = new System.Collections.Generic.LinkedListNode<Vector2>(new Vector2(50.0f, 50.0f));
            var t = new System.Collections.Generic.LinkedList<Vector2>();
            t.AddLast(c);
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, 50.0f));
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, Global.GAME.Height - 50.0f));
            t.AddLast(new Vector2(50, Global.GAME.Height - 50.0f));
            Movement = new CheckPointMovement(Speed, c);
            AddComponent(Movement);
            SetHitbox(32, 40, Global.HitBoxTag.Enemy);
        }

        public override void Update()
        {
            base.Update();
            var col = Collider.Collide(X, Y, Global.HitBoxTag.Bullet);
            if (col != null)
            {
                Health.Hurt(((IBullet)col.Entity).Damage);
                ((IBullet)col.Entity).Destroy();
            }
        }

        private void OnHurt()
        {
            OnDeathSprite.Play("explode");
            HurtSound.Play();
        }

        private void OnDeath()
        {
            RemoveSelf();
        }
    }
}
