using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD
{
    public class Resources
    {
        public class Img
        {
            private const string IMG_PATH = "img/";

            public const string TILE_IMG = IMG_PATH + "tiles.png";

            public class Tower
            {
                private const string TOWER_PATH = "tower/";

                public const string TOWER = IMG_PATH + TOWER_PATH + "tower.png";
                public const string TOWER_BULLET = IMG_PATH + TOWER_PATH + "bullet.png";
            }
        }

        public class Fonts
        {
            private const string FONTS_PATH = "fonts/";

            public const string FONT_MAIN = FONTS_PATH + "PanicStricken.ttf";
        }

        public class Music
        {
            private const string MUSIC_PATH = "music/";

            public const string INTRO_MUSIC = MUSIC_PATH + "Main-theme.ogg";
            public const string MAIN_MUSIC = MUSIC_PATH + "Ingame-theme.ogg";
        }
    }
}
