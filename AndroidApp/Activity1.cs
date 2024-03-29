using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using GameEntry;

namespace AndroidApp.Android
{
    [Activity(Label = "AndroidApp.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.FullUser
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = new Entry(ExitHandler);
            SetContentView((View)((Microsoft.Xna.Framework.Game)g).Services.GetService(typeof(View)));
            g.Run();
        }

        private static bool ExitHandler(Entry g)
        {
            ((Microsoft.Xna.Framework.Game)g).Exit();
            return true;
        }
    }
}

