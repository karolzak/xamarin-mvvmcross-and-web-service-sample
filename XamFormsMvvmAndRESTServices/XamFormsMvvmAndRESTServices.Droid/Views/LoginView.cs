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
using MvvmCross.Droid.Views;
using Android.Content.PM;

namespace XamMvvmAndWebServices.Droid.Views
{
    [Activity(Label = "LoginView",
        LaunchMode = LaunchMode.SingleTop, NoHistory =true)]
    public class LoginView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginView);
        }
    }
}