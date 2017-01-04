using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using XamMvvmAndWebServices.iOS.Helpers;
using System.Collections.Generic;

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
            //{
            //    UseAnimations = true,
            //    AddAnimation = UITableViewRowAnimation.Left,
            //    RemoveAnimation = UITableViewRowAnimation.Right
            //};
            set.Bind(source).To(vm => vm.Employees);
            set.Apply();
            //this.AddBindings(new Dictionary<object, string>
            //    {
            //        {source, "ItemsSource Employees"}
            //    });
            TableViewEmployees.Source = source;
            TableViewEmployees.ReloadData();
        }
    }
}
