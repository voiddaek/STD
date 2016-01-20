using Otter;

namespace STD
{
    class Global
    {
        public static int WIDTH = 800;
        public static int HEIGHT = 600;
        // Global Game instance
        public static Game GAME = null;
        // Global Player session
        public static Session PlayerSession;


        public enum HitBoxTag
        {
            Enemy = 0,
            Tower = 1,
            Bullet = 2,
        }
    }
}
