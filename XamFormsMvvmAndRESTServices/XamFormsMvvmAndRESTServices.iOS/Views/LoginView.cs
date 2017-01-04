using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class LoginView : MvxViewController
    {
        public LoginView() : base("LoginView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<LoginView, ViewModels.LoginViewModel>();
            set.Bind(UsernameBox).To(vm => vm.Username);
            set.Bind(PasswordBox).To(vm => vm.Password);
            set.Bind(LoginButton).To(vm => vm.LoginCommand);

            set.Apply();

        }

        //public override void ViewDidDisappear(bool animated)
        //{
        //    if (this.NavigationController != null)
        //    {
        //        var controllers = this.NavigationController.ViewControllers;
        //        var newcontrollers = new UIViewController[controllers.Length - 1];
        //        int index = 0;
        //        foreach (var item in controllers)
        //        {
        //            if (item != this)
        //            {
        //                newcontrollers[index] = item;
        //                index++;
        //            }

        //        }
        //        this.NavigationController.ViewControllers = newcontrollers;
        //    }
        //    base.ViewDidDisappear(animated);
        //}
    }
}