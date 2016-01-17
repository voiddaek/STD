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
            private const string IMG_PATH = "sprites/";

            public const string TILE_IMG = IMG_PATH + "tiles.png";

            public class Towers
            {
                private const string TOWERS_PATH = "towers/";

                public const string TOWER = IMG_PATH + TOWERS_PATH + "tower.png";
                public const string TOWER_BULLET = IMG_PATH + TOWERS_PATH + "bullet.png";
            }

            public class Enemies
            {
                private const string ENEMIES_PATH = "enemies/";

                public const string BASIC_ENEMY = IMG_PATH + ENEMIES_PATH + "enemy.png";
            }
        }

        public class Fonts
        {
            private const string FONTS_PATH = "fonts/";

            public const string FONT_MAIN = FONTS_PATH + "PanicStricken.ttf";
        }

        public class Music
        {
            private const string MUSIC_PATH = "musics/";

            public const string INTRO_MUSIC = MUSIC_PATH + "Main-theme.ogg";
            public const string MAIN_MUSIC = MUSIC_PATH + "Ingame-theme.ogg";
        }

        public class Sound
        {
            private const string SOUND_PATH = "sounds/";

            public class Enemies
            {
                private const string ENEMIES_PATH = "enemies/";

                public const string BASIC_ENEMY_HURT = SOUND_PATH + ENEMIES_PATH + "enemyHurt.ogg";
            }
        }
    }
}
