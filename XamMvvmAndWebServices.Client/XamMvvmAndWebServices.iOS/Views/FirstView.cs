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
            //var source = new MvxStandardTableViewSource(TableViewEmployees);
           
            //TableViewEmployees.Source = source;
            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
            var source = new EmployeeTableViewSource(TableViewEmployees);
            NavigationItem.Title = "Employees";
            source.SelectedItemChanged += Source_SelectedItemChanged; 

            //{
            //    UseAnimations = true,
            //    AddAnimation = UITableViewRowAnimation.Left,
            //    RemoveAnimation = UITableViewRowAnimation.Right
            //};
            set.Bind(source).To(vm => vm.Employees).Apply();
            set.Bind(source.SelectedItem).To(vm => vm.SelectedEmployee).Apply();
            set.Bind(source).For(x=>x.SelectionChangedCommand).To(vm => vm.NavigateToCustomersCommand).Apply();
            //this.AddBindings(new Dictionary<object, string>
            //    {
            //        {source, "ItemsSource Employees"}
            //    });
            TableViewEmployees.Source = source;
            TableViewEmployees.ReloadData();
        }

        private void Source_SelectedItemChanged(object sender, EventArgs e)
        {
            var x = NavigationController;
        }
    }
}
