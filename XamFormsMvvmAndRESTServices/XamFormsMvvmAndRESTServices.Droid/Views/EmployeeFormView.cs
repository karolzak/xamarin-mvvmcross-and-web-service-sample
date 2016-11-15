using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamMvvmAndWebServices.Droid.Views
{
    [Activity(Label = "Add/Edit Employee")]
    public class EmployeeFormView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EmployeeFormView);
        }
    }


}
