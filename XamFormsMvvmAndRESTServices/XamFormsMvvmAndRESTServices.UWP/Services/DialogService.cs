using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using XamMvvmAndWebServices.Interfaces;

namespace XamMvvmAndWebServices.UWP.Services
{
    public class DialogService : IDialogService
    {
        public void Alert(string message, string title, string okbtnText)
        {

            var dlg = new MessageDialog(message,title);
            dlg.Commands.Add(new UICommand(okbtnText, (e) => 
            {
            }
            ));
            dlg.ShowAsync();
        }
    }
}
