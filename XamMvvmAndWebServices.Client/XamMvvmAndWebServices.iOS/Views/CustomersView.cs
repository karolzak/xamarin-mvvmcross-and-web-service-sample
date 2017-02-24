using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;
using XamMvvmAndWebServices.iOS.Helpers;
using XamMvvmAndWebServices.ViewModels;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class CustomersView : MvxViewController
    {
        public CustomersView() : base("CustomersView", null)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            (ViewModel as CustomersViewModel).ReloadCommand.Execute(null);
            TableViewCustomers.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableViewCustomers.EstimatedRowHeight = 100;
            TableViewCustomers.RowHeight = 100;
            
            //Setting bottom toolbar
            var addButton = new UIBarButtonItem(UIBarButtonSystemItem.Add);
            this.SetToolbarItems(new UIBarButtonItem[]
            {
                addButton

            }, false);

            //Show the bottom toolbar
            this.NavigationController.NavigationBar.Translucent = false;
            this.NavigationController.ToolbarHidden = false;

            //Setting source for TableView
            var source = new CustomerTableViewSource(TableViewCustomers);

            //Setting bindings to View Model
            var set = this.CreateBindingSet<CustomersView, ViewModels.CustomersViewModel>();
            //Binding PageTitle and TableView source
            set.Bind(NavigationItem).For(s => s.Title).To(vm => vm.PageTitle).Apply();
            set.Bind(source).To(vm => vm.Customers).Apply();
            set.Bind(source).For(s => s.SelectedItem).To(vm => vm.SelectedCustomer).Apply();
            //Binding navigation commands and add/edit
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.NavigateToOrdersCommand).Apply();
            set.Bind(addButton).To(vm => vm.AddCommand).Apply();
            set.Bind(source).For(s => s.AccessoryTappedCommand).To(vm => vm.EditCommand).Apply();


            //Filling TableView with data from source
            TableViewCustomers.Source = source;
            TableViewCustomers.ReloadData();

        }
        
    }
}