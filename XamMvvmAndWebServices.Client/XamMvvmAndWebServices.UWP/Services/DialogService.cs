using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using XamMvvmAndWebServices.Interfaces;

namespace XamMvvmAndWebServices.UWP.Services
{
    //SHOW: IDialogService - Windows implementation
    public class DialogService : IDialogService
    {
        public async void Alert(string message, string title, string okbtnText)
        {

            var dlg = new MessageDialog(message,title);
            dlg.Commands.Add(new UICommand(okbtnText, (e) => 
            {
            }
            ));
            await dlg.ShowAsync();
        }
    }
}
