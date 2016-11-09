using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamMvvmAndWebServices.ViewModels
{
    public class CustomersViewModel: MvxViewModel
    {

        private string _pageTitle = "Hello to CustomersView";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }


        private IXamarinMVVMSampleWebAPIService _apiService;

        public CustomersViewModel(IXamarinMVVMSampleWebAPIService apiService)
        {
            _apiService = apiService;
        }

        private MvxCommand _navigateToOrdersCommand;
        public ICommand NavigateToOrdersCommand
        {
            get
            {
                _navigateToOrdersCommand = _navigateToOrdersCommand ?? new MvxCommand(() => NavigateToOrders());
                return _navigateToOrdersCommand;
            }
        }

        private void NavigateToOrders()
        {
            //ShowViewModel<CustomersViewModel>();
            ShowViewModel<OrdersViewModel>();
        }

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
    }
}
