﻿using System;
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
                private const string TOWERS_PATH = "towers/";

                public const string TOWER = IMG_PATH + TOWERS_PATH + "tower.png";
                public const string TOWER_BULLET = IMG_PATH + TOWERS_PATH + "bullet.png";
                public const string TOWER_BULLET_EXPLOSION = IMG_PATH + TOWERS_PATH + "explosion.png";
                public const string TOWER_BULLET_TRAIL = IMG_PATH + TOWERS_PATH + "particle.png";
            }

            public class Enemies
            {
                private const string ENEMIES_PATH = "enemies/";

                public const string ENEMY_1_BLUE = IMG_PATH + ENEMIES_PATH + "enemy_1_blue.png";
                public const string ENEMY_2_BLUE = IMG_PATH + ENEMIES_PATH + "enemy_2_blue.png";
                public const string ENEMY_3_BLUE = IMG_PATH + ENEMIES_PATH + "enemy_3_blue.png";
                public const string ENEMY_EXPLOSION = IMG_PATH + ENEMIES_PATH + "explosion.png";
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

        public class Shaders
        {
            private const string SHADERS_PATH = "shaders/";

            public const string BLAST_SHADER = SHADERS_PATH + "blast";
        }
    }
}
