using Foundation;
using MvvmCross.Binding.iOS.Views;
using System;
using UIKit;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.iOS.Views.Cells
{
    public partial class CustomerCellView : MvxTableViewCell
    {
        private const string BindingText = "CustomerName CustomerName";

        public static readonly NSString Key = new NSString("CustomerCellView");
        public static readonly UINib Nib = UINib.FromName("CustomerCellView", NSBundle.MainBundle);

      
        
        public CustomerCellView(IntPtr handle) : base(BindingText, handle)

        {

        }
        public string CustomerName

        {

            get { return LabelCustomerName.Text; }

            set { LabelCustomerName.Text = value; }

        }
        
    }
}