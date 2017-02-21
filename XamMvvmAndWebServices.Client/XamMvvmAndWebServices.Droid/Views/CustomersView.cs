using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamMvvmAndWebServices.Droid.Views
{
    [Activity(Label = "Customers")]
    public class CustomersView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CustomersView);
        }
    }


}
