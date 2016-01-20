using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace STD.Entities.Hud
{
    public class HudSurface : Entity
    {
        public Surface Hud { get; set; }

        public float MoveSpeed = 4;

        public float ScaleSpeed = 0.02f;

        public HudSurface()
        {
            //base.Added();

            Hud = new Surface(Global.GAME.Width / 2, Global.GAME.Height) { FillColor = Color.Shade(0.1f) };

           // AddGraphic(Hud);

            Hud.SetPosition(Global.GAME.Width / 2, 0);
        }
    }
}
