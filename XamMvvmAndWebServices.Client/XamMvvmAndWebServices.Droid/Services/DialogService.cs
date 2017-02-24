using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamMvvmAndWebServices.Interfaces;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace XamMvvmAndWebServices.Droid.Services
{
    //SHOW: IDialogService - Android implementation
    public class DialogService : IDialogService
    {
        /// <summary>Alerts the user with a simple OK dialog and provides a <paramref name="message"/>.</summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="okbtnText">The okbtn text.</param>
        public void Alert(string message, string title, string okbtnText)
        {
            var top = Mvx.Resolve<IMvxAndroidCurrentTopActivity>();
            var act = top.Activity;

            var adb = new AlertDialog.Builder(act);
            adb.SetTitle(title);
            adb.SetMessage(message);
            adb.SetIcon(Resource.Drawable.icon);
            adb.SetPositiveButton(okbtnText, (sender, args) => { /* some logic */ });
            adb.Create().Show();

            //AlertDialog.Builder alert = new AlertDialog.Builder(this);

            //alert.SetTitle("Hi, how are you");

            //alert.SetPositiveButton("Good", (senderAlert, args) => {
            //    //change value write your own set of instructions
            //    //you can also create an event for the same in xamarin
            //    //instead of writing things here
            //});

            //alert.SetNegativeButton("Not doing great", (senderAlert, args) => {
            //    //perform your own task for this conditional button click
            //});
            ////run the alert in UI thread to display in the screen
            //RunOnUiThread(() => {
            //    alert.Show();
            //});
        }

    }
}