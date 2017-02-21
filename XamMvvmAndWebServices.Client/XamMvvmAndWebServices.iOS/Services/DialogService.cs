using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using XamMvvmAndWebServices.Interfaces;

namespace XamMvvmAndWebServices.iOS.Services
{
    public class DialogService : IDialogService
    {
        public void Alert(string message, string title, string okbtnText)
        {
            UIAlertView alert = new UIAlertView();
            alert.Title = title;
            alert.Message = message;
            alert.AddButton(okbtnText);
            alert.Show();
        }
    }
}