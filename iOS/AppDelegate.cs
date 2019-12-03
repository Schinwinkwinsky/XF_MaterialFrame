using FFImageLoading.Forms.Platform;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using XF_Material;

namespace iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Xamarin.Forms.Forms.Init();

            CachedImageRenderer.Init();
            Xamarin.Forms.FormsMaterial.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(application, launchOptions);
        }
    }
}


