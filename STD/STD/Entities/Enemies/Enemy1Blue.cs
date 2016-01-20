using Otter;
using STD.Components;
using STD.Components.Movements;
using STD.Entities.Bullets;
using STD.Particles;
using System.Collections.Generic;

namespace STD.Entities.Enemies
{
    public class Enemy1Blue : IEnemy
    {
        public Wrapper<LinkedListNode<Vector2>> Path;
        public Enemy1Blue(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            HurtSound = new Sound(Resources.Sound.Enemies.BASIC_ENEMY_HURT);
            Sprite = new Spritemap<string>(Resources.Img.Enemies.ENEMY_1_BLUE, 46, 46);
            Sprite.Add("walk", new int[] { 0, 1, 2, 3, 4, 5 }, new float[] { 10f, 2f, 1f, 10f, 2f, 1f});
            Sprite.Play("walk");
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Health = new Life(10);
            Health.OnDeath = OnDeath;
            Health.OnHurt = OnHurt;
            Direction = new Wrapper<Vector2>(Vector2.Zero);
            Speed = new Wrapper<int>(600);
            var c = new LinkedListNode<Vector2>(new Vector2(50.0f, 50.0f));
            var t = new LinkedList<Vector2>();
            Path = new Wrapper<LinkedListNode<Vector2>>(c);
            t.AddLast(c);
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, 50.0f));
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, Global.GAME.Height - 50.0f));
            t.AddLast(new Vector2(50, Global.GAME.Height - 50.0f));
            //Movement = new CheckPointMovement(Speed, c);
            //AddComponent(Movement);
            AddComponent(new CheckPointMovement(Direction, Speed, Path));
            AddComponent(new Rotation(Direction));
            SetHitbox(23, 23, Global.HitBoxTag.Enemy);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Hurt(int damage)
        {
            Health.Hurt(damage);
        }

        private void OnHurt()
        {
            HurtSound.Play();
        }

        private void OnDeath()
        {
            Scene.Add(new EnemyExplosionParticle(X, Y));
            RemoveSelf();
        }
    }
}
