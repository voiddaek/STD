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
        }
    }
}
