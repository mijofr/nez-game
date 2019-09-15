using System;
using Foundation;
using UIKit;
using GameEntry;

namespace IosApp.iOS
{
    [Register("AppDelegate")]
    class Program : UIApplicationDelegate
    {
        private static Entry game;

        internal static void RunGame()
        {
            game = new Entry(ExitHandler);
            game.Run();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }

        public override void FinishedLaunching(UIApplication app)
        {
            RunGame();
        }

        private static bool ExitHandler(Entry g)
        {
            return false;
        }

    }
}
