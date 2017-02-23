using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using XamMvvmAndWebServices.iOS.Helpers;
using System.Collections.Generic;
using System.Windows.Input;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
            
        }
              
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Setting toolbar
            var addButton = new UIBarButtonItem(UIBarButtonSystemItem.Add);
            //var editButton = new UIBarButtonItem(UIBarButtonSystemItem.Edit);
            this.SetToolbarItems(new UIBarButtonItem[] 
            {
                addButton
            }, false);

            //Show the bottom toolbar
            this.NavigationController.NavigationBar.Translucent = false;
            this.NavigationController.ToolbarHidden = false;

            //Setting source for TableView
            var source = new EmployeeTableViewSource(TableViewEmployees);
            
            //Setting bindings with View Model
            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();          
            set.Bind(NavigationItem).For(s=>s.Title).To(vm => vm.PageTitle).Apply();
            set.Bind(source).To(vm => vm.Employees).Apply();
            set.Bind(source).For(s => s.SelectedItem).To(vm => vm.SelectedEmployee).Apply();
            set.Bind(source).For(s=>s.SelectionChangedCommand).To(vm => vm.NavigateToCustomersCommand).Apply();
            set.Bind(addButton).To(vm => vm.AddCommand).Apply();

            //Filling TableView with data from source
            TableViewEmployees.Source = source;
            TableViewEmployees.ReloadData();



        }        
    }
}
