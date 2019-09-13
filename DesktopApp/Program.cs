using System;
using GameEntry;

namespace DesktopApp
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Entry())
                game.Run();
        }
    }
}
