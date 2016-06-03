using Android.App;
using Android.OS;

namespace AndroidLogin
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ActionBar.Hide();
            
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }
    }
}

