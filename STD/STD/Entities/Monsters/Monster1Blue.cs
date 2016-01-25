using Otter;
using STD.Components;
using STD.Components.Movements;
using STD.Particles;
using System.Collections.Generic;

namespace STD.Entities.Monsters
{
    public class Monster1Blue : Monster
    {
        public LinkedListNode<Vector2> Path { get; set; }

        public Monster1Blue(float x = 0, float y = 0)
            : base(baseSpeed:600)
        {
            X = x;
            Y = y;
            HurtSound = new Sound(Resources.Sound.Monsters.BASIC_ENEMY_HIT);
            HurtSound.Volume = 0.1f;
            DeathSound = new Sound(Resources.Sound.Monsters.BASIC_ENEMY_EXPLOSION);
            DeathSound.Volume = 0.7f;
            Sprite = new Spritemap<string>(Resources.Sprites.Monsters.ENEMY_1_BLUE, 46, 46);
            Sprite.Add("walk", new int[] { 0, 1, 2, 3, 4, 5 }, new float[] { 10f, 2f, 1f, 10f, 2f, 1f });
            Sprite.Play("walk");
            Graphic = Sprite;
            Graphic.CenterOrigin();
            Health = new Life(10);
            Health.OnDeath = OnDeath;
            Health.OnHurt = OnHurt;
            Direction = Vector2.Zero;
            var c = new LinkedListNode<Vector2>(new Vector2(50.0f, 50.0f));
            var t = new LinkedList<Vector2>();
            Path = c;
            t.AddLast(c);
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, 50.0f));
            t.AddLast(new Vector2(Global.GAME.Width - 50.0f, Global.GAME.Height - 50.0f));
            t.AddLast(new Vector2(50, Global.GAME.Height - 50.0f));
            AddComponent(new CheckPointMovement(this, Path));
            AddComponent(new Rotation(this, 90));
            AddComponent(Health);
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
            DeathSound.Play();
            Scene.Add(new MonsterExplosionParticle(X, Y));
            RemoveSelf();
        }
    }
}
