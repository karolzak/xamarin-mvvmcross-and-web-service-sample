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
    [Register ("CustomerCellView")]
    partial class CustomerCellView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCustomerCount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCustomerName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelCustomerCount != null) {
                LabelCustomerCount.Dispose ();
                LabelCustomerCount = null;
            }

            if (LabelCustomerName != null) {
                LabelCustomerName.Dispose ();
                LabelCustomerName = null;
            }
        }
    }
}