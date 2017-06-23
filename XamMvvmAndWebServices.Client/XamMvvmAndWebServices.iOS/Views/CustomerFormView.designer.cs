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
    [Register ("CustomerFormView")]
    partial class CustomerFormView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTelNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldCity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldTelNumber { get; set; }

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

            if (LabelName != null) {
                LabelName.Dispose ();
                LabelName = null;
            }

            if (LabelTelNumber != null) {
                LabelTelNumber.Dispose ();
                LabelTelNumber = null;
            }

            if (TextFieldAddress != null) {
                TextFieldAddress.Dispose ();
                TextFieldAddress = null;
            }

            if (TextFieldCity != null) {
                TextFieldCity.Dispose ();
                TextFieldCity = null;
            }

            if (TextFieldName != null) {
                TextFieldName.Dispose ();
                TextFieldName = null;
            }

            if (TextFieldTelNumber != null) {
                TextFieldTelNumber.Dispose ();
                TextFieldTelNumber = null;
            }
        }
    }
}