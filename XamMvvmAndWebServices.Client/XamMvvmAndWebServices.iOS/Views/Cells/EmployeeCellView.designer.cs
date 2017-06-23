// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
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
    partial class EmployeeCellView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCustomerCount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelFirstname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelLastname { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelCustomerCount != null) {
                LabelCustomerCount.Dispose ();
                LabelCustomerCount = null;
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