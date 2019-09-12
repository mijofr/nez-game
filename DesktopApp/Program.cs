using System;
using GameEntry;

namespace test
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
