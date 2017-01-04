using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.iOS.Views;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        partial void TestClickHandler(UIButton sender)
        {
            var x =NavigationController.ViewControllers;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var source = new MvxStandardTableViewSource(TableViewEmployees);
            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.PageTitle);
            set.Bind(TextField).To(vm => vm.PageTitle);
            set.Bind(TableViewEmployees).To(vm => vm.Employees);
            set.Apply();
        }
    }
}
