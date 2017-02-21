using Foundation;
using MvvmCross.Binding.iOS.Views;
using System;
using UIKit;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.iOS.Views.Cells
{
    public partial class EmployeeCellView : MvxTableViewCell
    {
        private const string BindingText = "FirstName FirstName;LastName LastName;CustCount Customers.Count";

        public static readonly NSString Key = new NSString("EmployeeCellView");
        public static readonly UINib Nib = UINib.FromName("EmployeeCellView", NSBundle.MainBundle);

      

        public EmployeeCellView(IntPtr handle) : base(BindingText, handle)

        {

        }
        public string FirstName

        {

            get { return LabelFirstname.Text; }

            set { LabelFirstname.Text = value; }

        }
        public string LastName

        {

            get { return LabelLastname.Text; }

            set { LabelLastname.Text = value; }

        }
        public int CustCount

        {

            get { return Convert.ToInt32(LabelCustomerCount.Text); }

            set { LabelCustomerCount.Text = Convert.ToString(value); }

        }
    }
}