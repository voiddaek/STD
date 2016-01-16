using Otter;
using STD.Components;
using STD.Entities;
using STD.Components.Interface;
using STD.Entities.Interface;

namespace STD.Entities
{
    public class BasicEnemy : IEnemy
    {

        public BasicEnemy(float x = 0, float y = 0)
            : base(new Spritemap<string>(Resources.Img.Enemies.BASIC_ENEMY, 32, 40), x, y)
        {
            Health = 10;
            Speed = 3;
            Sprite.Add("standLeft", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("standRight", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("standDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Add("standUp", new int[] { 6, 7 }, new float[] { 10f, 10f });
            Sprite.Add("walkLeft", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("walkRight", new int[] { 0, 1 }, new float[] { 10f, 10f });
            Sprite.Add("walkDown", new int[] { 3, 4 }, new float[] { 10f, 10f });
            Sprite.Add("walkUp", new int[] { 6, 7 }, new float[] { 10f, 10f });
            Sprite.Play("standLeft");

            SetHitbox(32, 40, 0);
        }

        public override void Update()
        {
            base.Update();
            var col = Collider.Collide(X, Y, 1);
            if (col != null)
            {
                Health -= ((IBullet)col.Entity).Damage;
                ((IBullet)col.Entity).Destroy();
                if (Health <= 0)
                    RemoveSelf();
            }

            // If going left, flip the spritesheet
            Sprite.FlippedX = direction;

            // if moving left then go left, otherwise go right
            if (direction)
            {
                X -= Speed;
            }
            else
            {
                X += Speed;
            }

            // Update distance moved, and check if we should flip directions
            distMoved += Speed;
            if (distMoved >= MOVE_DISTANCE)
            {
                direction = !direction;
                distMoved = 0f;
            }
        }
    }
}
