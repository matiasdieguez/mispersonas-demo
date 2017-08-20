using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Support.V7.App;

namespace MisPersonasApp.Droid
{
    [Activity(Label = "MisPersonasApp", Icon = "@drawable/icon", Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}