using Android.App;
using Android.Content.PM;
using Android.OS;
using System.Reflection.Metadata;

namespace Modul_335
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Android-spezifische Initialisierungen können hier durchgeführt werden
        }
    }
}
