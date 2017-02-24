// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamMvvmAndWebServices.iOS.Views.Cells
{
    [Register ("OrderCellView")]
    partial class OrderCellView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelProductName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelQuantity { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelProductName != null) {
                LabelProductName.Dispose ();
                LabelProductName = null;
            }

            if (LabelQuantity != null) {
                LabelQuantity.Dispose ();
                LabelQuantity = null;
            }
        }
    }
}