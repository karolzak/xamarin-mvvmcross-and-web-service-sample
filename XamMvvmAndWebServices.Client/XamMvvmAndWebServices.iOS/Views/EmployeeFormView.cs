using System;

using UIKit;

namespace XamMvvmAndWebServices.iOS.Views
{
    public partial class EmployeeFormView : UIViewController
    {
        public EmployeeFormView() : base("EmployeeFormView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}