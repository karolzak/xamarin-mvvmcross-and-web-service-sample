using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamFormsMvvmAndRESTServices.Droid.Views
{
    [Activity(Label = "View for CustomersViewModel")]
    public class CustomersView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CustomersView);
        }
    }
}
