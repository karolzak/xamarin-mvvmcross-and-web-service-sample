using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamFormsMvvmAndRESTServices.ViewModels
{
    public class OrdersViewModel : MvxViewModel
    {

        private string _pageTitle = "Hello to OrdersView";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        #region Commands
        private MvxCommand _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand(() => GoBack());
                return _goBackCommand;
            }
        }

        private void GoBack()
        {
            Close(this);
        }

        #endregion
    }
}
