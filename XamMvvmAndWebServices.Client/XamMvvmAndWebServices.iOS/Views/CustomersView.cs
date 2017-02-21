using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;
using XamMvvmAndWebServices.iOS.Helpers;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class CustomersView : MvxViewController
    {
        public CustomersView() : base("CustomersView", null)
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

            var set = this.CreateBindingSet<CustomersView, ViewModels.CustomersViewModel>();
            var source = new CustomerTableViewSource(TableViewCustomers);
            NavigationItem.Title = "Customers";

            //{
            //    UseAnimations = true,
            //    AddAnimation = UITableViewRowAnimation.Left,
            //    RemoveAnimation = UITableViewRowAnimation.Right
            //};
            set.Bind(NavigationItem.BackBarButtonItem).To(vm => vm.GoBackCommand).Apply();
            set.Bind(source).To(vm => vm.Customers).Apply();
            set.Bind(source.SelectedItem).To(vm => vm.SelectedCustomer).Apply();
            set.Bind(source).For(x => x.SelectionChangedCommand).To(vm => vm.NavigateToOrdersCommand).Apply();
            
            //this.AddBindings(new Dictionary<object, string>
            //    {
            //        {source, "ItemsSource Employees"}
            //    });
            TableViewCustomers.Source = source;
            TableViewCustomers.ReloadData();
        }
        
    }
}