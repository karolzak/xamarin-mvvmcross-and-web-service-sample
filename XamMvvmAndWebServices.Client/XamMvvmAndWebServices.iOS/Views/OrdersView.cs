using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;
using XamMvvmAndWebServices.iOS.Helpers;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class OrdersView : MvxViewController
    {
        public OrdersView() : base("OrdersView", null)
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
            var set = this.CreateBindingSet<OrdersView, ViewModels.OrdersViewModel>();
            var source = new OrderTableViewSource(TableViewOrders);
            NavigationItem.Title = "Orders";

            //{
            //    UseAnimations = true,
            //    AddAnimation = UITableViewRowAnimation.Left,
            //    RemoveAnimation = UITableViewRowAnimation.Right
            //};
            //set.Bind(NavigationItem.BackBarButtonItem).To(vm => vm.GoBackCommand).Apply();
            set.Bind(source).To(vm => vm.Customer.Orders).Apply();
            set.Bind(source).For(s => s.SelectedItem).To(vm => vm.SelectedOrder).Apply();
            //set.Bind(source).For(x => x.SelectionChangedCommand).To(vm => vm.NavigateToOrdersCommand).Apply();

            //this.AddBindings(new Dictionary<object, string>
            //    {
            //        {source, "ItemsSource Employees"}
            //    });
            TableViewOrders.Source = source;
            TableViewOrders.ReloadData();
        }
    }
}