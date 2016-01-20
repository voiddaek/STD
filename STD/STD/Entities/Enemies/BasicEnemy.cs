using Otter;
using STD.Components;
using STD.Components.Movements;
using STD.Entities.Interface;

namespace STD.Entities.Enemies
{
    public class BasicEnemy : IEnemy
    {

        public BasicEnemy(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            HurtSound = new Sound(Resources.Sound.Enemies.BASIC_ENEMY_HURT);
            Sprite = new Spritemap<string>(Resources.Img.Enemies.BASIC_ENEMY, 32, 40);
            Sprite.Add("standLeft", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("standRight", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("standDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Add("standUp", new int[] { 6, 7 }, new float[] { 10f, 10f });
            Sprite.Add("walkLeft", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("walkRight", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("walkDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Add("walkUp", new int[] { 6, 7 }, new float[] { 10f, 10f });
            Sprite.Play("standLeft");
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Health = new Life(10);
            Health.OnDeath = OnDeath;
            Health.OnHurt = OnHurt;
            Speed = 2;
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
            HurtSound.Play();
            Graphic.Shake = 20;
        }

        private void OnDeath()
        {
            RemoveSelf();
        }
    }
}
