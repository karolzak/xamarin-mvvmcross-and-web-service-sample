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
using HockeyApp.Android.Metrics;
using HockeyApp.Android;

namespace XamMvvmAndWebServices.Droid.Views
{
    [Activity(Label = "LoginView", NoHistory =true)]
    public class LoginView : MvxActivity
    {
        public const string HOCKEYAPP_APPID = "1d95054d55f340e0a6d06752ba273a45";
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            CrashManager.Register(this, HOCKEYAPP_APPID);
            MetricsManager.Register(Application, HOCKEYAPP_APPID);
            SetContentView(Resource.Layout.LoginView);
        }
    }
}