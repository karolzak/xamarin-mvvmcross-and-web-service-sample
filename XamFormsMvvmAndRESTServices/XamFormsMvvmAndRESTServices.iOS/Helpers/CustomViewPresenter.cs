using MvvmCross.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using XamMvvmAndWebServices.ViewModels;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace XamMvvmAndWebServices.iOS.Helpers
{
    //SHOW Mvx - Custom ViewPresenter to clear back stack
    //used just for ChangePresentation to clear backstack
    public class CustomViewPresenter : MvxIosViewPresenter
    {
        public CustomViewPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {

        }

        public override void Show(MvxViewModelRequest request)
        {
            //if (request.PresentationValues?["NavigationMode"] == "ClearStack")
            //{

            //    MasterNavigationController.PopViewController(false);
            //    return;
            //}

            base.Show(request);
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is ClearBackStackHint)
            {
               MasterNavigationController.PopViewController(false);
            }

            base.ChangePresentation(hint);
        }
    }
}

