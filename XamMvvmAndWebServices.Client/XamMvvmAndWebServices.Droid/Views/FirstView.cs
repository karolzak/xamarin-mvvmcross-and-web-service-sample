using Android.App;
using Android.OS;
//using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;


namespace XamMvvmAndWebServices.Droid.Views
{

    //SHOW: Android - Activity
    [Activity(Label = "Employees")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
            
        }
        
    }


}
