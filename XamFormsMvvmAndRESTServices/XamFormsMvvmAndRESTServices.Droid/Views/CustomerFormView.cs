using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamMvvmAndWebServices.Droid.Views
{
    [Activity(Label = "Add/Edit Customer")]
    public class CustomerFormView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CustomerFormView);
        }
    }


}
