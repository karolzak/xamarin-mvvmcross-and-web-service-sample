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
    [Register ("CustomerCellView")]
    partial class CustomerCellView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCustomerName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelDateJoined { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelOrdersCount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelAddress != null) {
                LabelAddress.Dispose ();
                LabelAddress = null;
            }

            if (LabelCity != null) {
                LabelCity.Dispose ();
                LabelCity = null;
            }

            if (LabelCustomerName != null) {
                LabelCustomerName.Dispose ();
                LabelCustomerName = null;
            }

            if (LabelDateJoined != null) {
                LabelDateJoined.Dispose ();
                LabelDateJoined = null;
            }

            if (LabelOrdersCount != null) {
                LabelOrdersCount.Dispose ();
                LabelOrdersCount = null;
            }
        }
    }
}