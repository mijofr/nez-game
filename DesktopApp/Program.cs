using System;
using GameEntry;

namespace DesktopApp
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Entry(ExitHandler))
                game.Run();
        }

        private static bool ExitHandler(Entry g)
        {
            ((Microsoft.Xna.Framework.Game)g).Exit();
            return true;
        }

    }
}
