using Otter;
namespace STD.Entities
{
    public class DamageText : Entity
    {
        private Text text;
        public DamageText(float x, float y, string dmgText, int fontSize = 16)
        {
            text = new Text(dmgText, fontSize);
            text.Color = Color.Red;
            X = x + Otter.Rand.Int(0, 30);
            Y = y - 20;
            Graphic = text;
        }

        public override void Update()
        {
            base.Update();
            text.Alpha -= 0.02f;
            Y -= 1.25f;
            if (text.Alpha <= 0)
                RemoveSelf();
        }
    }
}
