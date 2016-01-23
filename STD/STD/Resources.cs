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
            public const string BACKGROUND = IMG_PATH + "background.png";

            public class Towers
            {
                private const string TOWERS_PATH = IMG_PATH + "towers/";

                public const string TOWER_1_1 = TOWERS_PATH + "turret-1-1.png";
                public const string TOWER_1_2 = TOWERS_PATH + "turret-1-2.png";
                public const string TOWER_1_3 = TOWERS_PATH + "turret-1-3.png";
                public const string TOWER_2_1 = TOWERS_PATH + "turret-2-1.png";
                public const string TOWER_2_2 = TOWERS_PATH + "turret-2-2.png";
                public const string TOWER_2_3 = TOWERS_PATH + "turret-2-3.png";
                public const string TOWER_3_1 = TOWERS_PATH + "turret-3-1.png";
                public const string TOWER_3_2 = TOWERS_PATH + "turret-3-2.png";
                public const string TOWER_3_3 = TOWERS_PATH + "turret-3-3.png";
                public const string TOWER_4_1 = TOWERS_PATH + "turret-4-1.png";
                public const string TOWER_4_2 = TOWERS_PATH + "turret-4-2.png";
                public const string TOWER_4_3 = TOWERS_PATH + "turret-4-3.png";
                public const string TOWER_5_1 = TOWERS_PATH + "turret-5-1.png";
                public const string TOWER_5_2 = TOWERS_PATH + "turret-5-2.png";
                public const string TOWER_5_3 = TOWERS_PATH + "turret-5-3.png";
                public const string TOWER_6_1 = TOWERS_PATH + "turret-6-1.png";
                public const string TOWER_6_2 = TOWERS_PATH + "turret-6-2.png";
                public const string TOWER_6_3 = TOWERS_PATH + "turret-6-3.png";
                public const string TOWER_7_1 = TOWERS_PATH + "turret-7-1.png";
                public const string TOWER_7_2 = TOWERS_PATH + "turret-7-2.png";
                public const string TOWER_7_3 = TOWERS_PATH + "turret-7-3.png";
                public const string TOWER_BULLET_EXPLOSION = TOWERS_PATH + "explosion.png";
                public const string TOWER_BULLET_TRAIL = TOWERS_PATH + "particle.png";
            }

            public class Bullets
            {
                private const string BULLETS_PATH = IMG_PATH + "bullets/";

                public const string BULLET_RED_1_1 = BULLETS_PATH + "bullet-red-1-1.png";
                public const string BULLET_BLUE_1_1 = BULLETS_PATH + "bullet-blue-1-1.png";
                public const string BULLET_YELLOW_1_1 = BULLETS_PATH + "turret-1-3.png";
                public const string BULLET_GREEN_1_1 = BULLETS_PATH + "bullet-yellow-1-1.png";
            }

            public class Enemies
            {
                private const string ENEMIES_PATH = IMG_PATH + "enemies/";

                public const string ENEMY_1_BLUE = ENEMIES_PATH + "enemy_1_blue.png";
                public const string ENEMY_2_BLUE = ENEMIES_PATH + "enemy_2_blue.png";
                public const string ENEMY_3_BLUE = ENEMIES_PATH + "enemy_3_blue.png";
                public const string ENEMY_EXPLOSION = ENEMIES_PATH + "explosion.png";
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
                private const string ENEMIES_PATH = SOUND_PATH + "enemies/";

                public const string BASIC_ENEMY_HURT = ENEMIES_PATH + "enemyHurt.ogg";
            }
        }

        public class Shaders
        {
            private const string SHADERS_PATH = "shaders/";

            public const string BLAST_SHADER = SHADERS_PATH + "blast.frag";
        }
    }
}
