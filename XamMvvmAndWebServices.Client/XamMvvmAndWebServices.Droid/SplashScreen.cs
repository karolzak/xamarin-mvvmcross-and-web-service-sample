using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamMvvmAndWebServices.Droid
{

    //SHOW Mvx - Android main launcher
    [Activity(
        Label = "XamMvvmAndWebServices.Droid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {

        
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {


        }
    }
}
