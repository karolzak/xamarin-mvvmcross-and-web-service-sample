using System;
using MvvmCross.Binding.BindingContext;

using UIKit;
using MvvmCross.iOS.Views;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class EmployeeFormView : MvxViewController
    {
        public EmployeeFormView() : base("EmployeeFormView", null)
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

            //Setting bottom toolbar
            var saveButton = new UIBarButtonItem(UIBarButtonSystemItem.Save);
            var discardButton = new UIBarButtonItem(UIBarButtonSystemItem.Cancel);
            this.SetToolbarItems(new UIBarButtonItem[]
            {
                saveButton,
                discardButton
            }, false);

            //Show the bottom toolbar
            this.NavigationController.ToolbarHidden = false;

            //Setting bindings with View Model
            var set = this.CreateBindingSet<EmployeeFormView, ViewModels.EmployeeFormViewModel>();
            //Binding Page Title to PageTitle property in VM
            set.Bind(NavigationItem).For(s => s.Title).To(vm => vm.PageTitle).Apply();
            //Binding Back, Save and Discard buttons to propper commands in VM
            set.Bind(NavigationItem).For(s => s.BackBarButtonItem).To(vm => vm.DiscardCommand).Apply();
            set.Bind(saveButton).To(vm => vm.SaveCommand).Apply();
            set.Bind(discardButton).To(vm => vm.DiscardCommand).Apply();


        }
    }
}