using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;
using XamMvvmAndWebServices.ViewModels;

namespace XamMvvmAndWebServices.Droid.Helpers
{
    public class CustomViewPresenter : MvxAndroidViewPresenter
    {

        public CustomViewPresenter()
            : base()
        {

        }
        public override void Show(MvxViewModelRequest request)
        {
            if (request.PresentationValues?["NavigationMode"] == "ClearStack")
            {

                var intent = CreateIntentForRequest(request);
                intent.AddFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask);
                Show(intent);
                return;
            }

            base.Show(request);
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is ClearBackStackHint)
            {


            }

            base.ChangePresentation(hint);
        }
    }
}