// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamMvvmAndWebServices.iOS.Views
{
    [Register ("OrderFormView")]
    partial class OrderFormView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldQuantity { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TextFieldName != null) {
                TextFieldName.Dispose ();
                TextFieldName = null;
            }

            if (TextFieldQuantity != null) {
                TextFieldQuantity.Dispose ();
                TextFieldQuantity = null;
            }
        }
    }
}