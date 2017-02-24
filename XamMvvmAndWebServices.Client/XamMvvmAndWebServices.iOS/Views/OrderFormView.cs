using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class OrderFormView : MvxViewController
    {
        public OrderFormView() : base("OrderFormView", null)
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

            //Setting up custom back button
            //var backButton = new UIBarButtonItem("Employees", UIBarButtonItemStyle.Plain, (sender, args) => { });
            //NavigationItem.SetLeftBarButtonItem(backButton, true);

            //Setting bottom toolbar
            var saveButton = new UIBarButtonItem(UIBarButtonSystemItem.Save);
            var discardButton = new UIBarButtonItem(UIBarButtonSystemItem.Cancel);
            this.SetToolbarItems(new UIBarButtonItem[]
            {
                saveButton,
                new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace) { Width = 50 },
                discardButton
            }, false);

            //Show the bottom toolbar
            this.NavigationController.ToolbarHidden = false;

            //Setting bindings with View Model
            var set = this.CreateBindingSet<OrderFormView, ViewModels.OrderFormViewModel>();
            //Binding Page Title to PageTitle property in VM
            set.Bind(NavigationItem).For(s => s.Title).To(vm => vm.PageTitle).Apply();
            //Binding Controls with Properties in VM
            set.Bind(TextFieldName).For(s => s.Text).To(vm => vm.Order.ProductName).Apply();
            set.Bind(TextFieldQuantity).For(s => s.Text).To(vm => vm.Order.Quantity).WithConversion("IntToStringConverter").Apply();
            //Binding Back, Save and Discard buttons to propper commands in VM           
            set.Bind(saveButton).To(vm => vm.SaveCommand).Apply();
            set.Bind(discardButton).To(vm => vm.DiscardCommand).Apply();
            //    this.AddBindings(new Dictionary<object, string>(){
            //    { backButton, "Clicked DiscardCommand"}
            //});
        }
    }
}