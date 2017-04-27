using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace XamMvvmAndWebServices.UITests.Droid
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.

            app = ConfigureApp.Android.ApkFile(@"D:\GitHub\Xamarin-MVVMCross-And-Web-Service-Sample\XamMvvmAndWebServices.Client\XamMvvmAndWebServices.Droid\bin\Release\XamMvvmAndWebServices.Droid.apk").StartApp();

            //app = ConfigureApp
            //    .Android
            //    .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void NewTest()
        {

            app.WaitForElement(x => x.Id("textView1"));
            app.Screenshot("Waited for view with class: TextView with id: textView1 with text: Login on demo app");
            app.Tap(x => x.Id("TbxUsername"));
            app.EnterText(x => x.Id("TbxUsername"), "admin");
            app.Tap(x => x.Id("TbxPassword"));
            app.EnterText(x => x.Id("TbxPassword"), "admin");


            app.Tap(x => x.Id("BtnLogin"));
            
            app.WaitForElement(x => x.Text("add"));
            app.Screenshot("Waited for view with class: Button with text: add");
            app.Tap(x => x.Text("Karol"));
            app.WaitForElement(x => x.Text("Go Back"));
            app.Screenshot("Waited for view with class: Button with text: Go Back");
            app.Tap(x => x.Text("Go Back"));
            app.WaitForElement(x => x.Text("edit"));
            app.Screenshot("Waited for view with class: Button with text: edit");
        }
        
    }
}

