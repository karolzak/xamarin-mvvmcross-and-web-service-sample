using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamFormsMvvmAndRESTServices.Droid.Views
{
    [Activity(Label = "View for OrdersViewModel")]
    public class OrdersView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.OrdersView);
        }
    }
}
