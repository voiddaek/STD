﻿using Otter;
using STD.Components;
using STD.Components.Movements;
using STD.Entities.Bullets;
using STD.Particles;

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
            Health = new Life(18);
            Health.OnDeath = OnDeath;
            Health.OnHurt = OnHurt;
            Speed = 150;
            var c = new System.Collections.Generic.LinkedListNode<Vector2>(new Vector2(50.0f, 50.0f));
            var t = new System.Collections.Generic.LinkedList<Vector2>();
            t.AddLast(c);
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, 50.0f));
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, Global.GAME.Height - 50.0f));
            t.AddLast(new Vector2(50, Global.GAME.Height - 50.0f));
            Movement = new CheckPointMovement(Speed, c);
            AddComponent(Movement);
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
