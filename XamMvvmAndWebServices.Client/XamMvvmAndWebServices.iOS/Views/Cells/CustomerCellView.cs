using Foundation;
using MvvmCross.Binding.iOS.Views;
using System;
using UIKit;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.iOS.Views.Cells
{
    public partial class CustomerCellView : MvxTableViewCell
    {
        private const string BindingText = "CustomerName CustomerName;DateJoined DateJoined;City City;Address Address;OrdersCount Orders.Count";

        public static readonly NSString Key = new NSString("CustomerCellView");
        public static readonly UINib Nib = UINib.FromName("CustomerCellView", NSBundle.MainBundle);

       
        
        public CustomerCellView(IntPtr handle) : base(BindingText, handle)

        {
            this.Accessory = UITableViewCellAccessory.DetailDisclosureButton;  // implement AccessoryButtonTapped

        }
        public string CustomerName

        {

            get { return LabelCustomerName.Text; }

            set { LabelCustomerName.Text = value; }

        }
        public DateTimeOffset DateJoined

        {

            get { return Convert.ToDateTime(LabelDateJoined.Text); }

            set { LabelDateJoined.Text = value.ToString("dd/MM/yyyy"); }

        }
        public string City

        {

            get { return LabelCity.Text; }

            set { LabelCity.Text = value; }

        }
        public string Address

        {

            get { return LabelAddress.Text; }

            set { LabelAddress.Text = value; }

        }
        public int OrdersCount

        {

            get { return Convert.ToInt32(LabelOrdersCount.Text); }

            set { LabelOrdersCount.Text = Convert.ToString(value); }

        }

    }
}