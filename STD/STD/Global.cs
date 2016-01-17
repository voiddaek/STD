using Otter;

namespace STD
{
    class Global
    {
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
