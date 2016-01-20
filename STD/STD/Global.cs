using Otter;

namespace STD
{
    class Global
    {
        public static string NAME = "STD";
        public static int WIDTH = 800;
        public static int HEIGHT = 600;
        public static int FPS = 45;
        public static Game GAME = null;
        public static Session PlayerSession;


        public enum HitBoxTag
        {
            Enemy = 0,
            Tower = 1,
            Bullet = 2,
        }
    }
}
