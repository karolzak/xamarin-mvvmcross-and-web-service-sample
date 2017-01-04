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
            if (request.PresentationValues?["NavigationMode"] == "ClearStack")
            {
                //This approach leaves a black blank screen before loading another page
                //if (this.MasterNavigationController != null)
                //{
                //    var controllers = this.MasterNavigationController.ViewControllers;
                //    var newcontrollers = new UIViewController[controllers.Length - 1];
                    
                //    this.MasterNavigationController.ViewControllers = newcontrollers;
                //}
            }
            base.Show(request);
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is ClearBackStackHint)
            {
                //this approach navigates to another screen and then removes the back button
                if (this.MasterNavigationController != null)
                {
                    var controllers = this.MasterNavigationController.ViewControllers;
                    var newcontrollers = new UIViewController[controllers.Length - 1];
                    int index = 0;
                    foreach (var item in controllers)
                    {
                        newcontrollers[index] = item;
                        index++;
                        if (index == controllers.Length - 1)
                            break;
                    }
                    this.MasterNavigationController.ViewControllers = newcontrollers;
                }
            }

            base.ChangePresentation(hint);
        }
    }
}

