using System;

using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;

namespace XamMvvmAndWebServices.iOS.Views.Cells
{
    public partial class OrderCellView : MvxTableViewCell
    {
        private const string BindingText = "ProductName ProductName;Quantity Quantity";
        public static readonly NSString Key = new NSString("OrderCellView");
        public static readonly UINib Nib = UINib.FromName("OrderCellView", NSBundle.MainBundle);

        public OrderCellView(IntPtr handle) : base(BindingText, handle)

        {

        }
        public string ProductName

        {

            get { return LabelProductName.Text; }

            set { LabelProductName.Text = value; }

        }
        public int Quantity

        {

            get { return Convert.ToInt32(LabelQuantity.Text); }

            set { LabelQuantity.Text = Convert.ToString(value); }

        }
    }
}
