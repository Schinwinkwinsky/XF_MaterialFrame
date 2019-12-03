using Android.App;
using Android.OS;
using FFImageLoading.Forms.Platform;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF_Material;

namespace Droid
{
    [Activity(MainLauncher = true)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);

            CachedImageRenderer.Init(true);
            Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}