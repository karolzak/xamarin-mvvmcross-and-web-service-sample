using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using XamMvvmAndWebServices.iOS.Helpers;
using System.Collections.Generic;
using System.Windows.Input;
using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Binding.Bindings;
using System.ComponentModel;
using System.Linq.Expressions;
using XamMvvmAndWebServices.ViewModels;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        
        
        public FirstView() : base("FirstView", null)
        {
           
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            (ViewModel as FirstViewModel).ReloadCommand.Execute(null);
            TableViewEmployees.ReloadData();

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

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
            var source = new EmployeeTableViewSource(TableViewEmployees);
            
            //Setting bindings to View Model
            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
            //Binding PageTitle and TableView source
            set.Bind(NavigationItem).For(s => s.Title).To(vm => vm.PageTitle).Apply();
            set.Bind(source).To(vm => vm.Employees).Apply();
            set.Bind(source).For(s => s.SelectedItem).To(vm => vm.SelectedEmployee).Apply();
            //Binding navigation commands and add/edit
            set.Bind(source).For(s=>s.SelectionChangedCommand).To(vm => vm.NavigateToCustomersCommand).Apply();
            set.Bind(addButton).To(vm => vm.AddCommand).Apply();
            set.Bind(source).For(s=>s.AccessoryTappedCommand).To(vm => vm.EditCommand).Apply();



            //Filling TableView with data from source
            TableViewEmployees.Source = source;
            TableViewEmployees.ReloadData();
            
        }

        public bool ShouldAlwaysRaiseInpcOnUserInterfaceThread()
        {
            throw new NotImplementedException();
        }

        public void ShouldAlwaysRaiseInpcOnUserInterfaceThread(bool value)
        {
            throw new NotImplementedException();
        }

        public void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            throw new NotImplementedException();
        }

        public void RaisePropertyChanged(string whichProperty)
        {
            throw new NotImplementedException();
        }

        public void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            throw new NotImplementedException();
        }
    }
    

}
