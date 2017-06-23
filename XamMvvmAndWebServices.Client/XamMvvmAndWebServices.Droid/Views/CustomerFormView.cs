using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using XamMvvmAndWebServices.ViewModels;

namespace XamMvvmAndWebServices.Droid.Views
{
    [Activity(Label = "Add/Edit Customer")]
    public class CustomerFormView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CustomerFormView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetActionBar(toolbar);

        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Layout.menu_formViews, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Resource.Id.menu_save:

                    (ViewModel as CustomerFormViewModel).SaveCommand.Execute(null);
                    return true;

                case Resource.Id.menu_discard:

                    (ViewModel as CustomerFormViewModel).DiscardCommand.Execute(null);
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

    }


}
