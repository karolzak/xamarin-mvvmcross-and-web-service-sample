// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using MvvmCross.Binding.iOS.Views;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamMvvmAndWebServices.iOS.Views.Cells
{
    [Register ("EmployeeCellView")]
    public partial class EmployeeCellView : MvxTableViewCell
    {
        

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCustomerNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelFirstname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelLastname { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelCustomerNumber != null) {
                LabelCustomerNumber.Dispose ();
                LabelCustomerNumber = null;
            }

            if (LabelFirstname != null) {
                LabelFirstname.Dispose ();
                LabelFirstname = null;
            }

            if (LabelLastname != null) {
                LabelLastname.Dispose ();
                LabelLastname = null;
            }
        }
    }
}