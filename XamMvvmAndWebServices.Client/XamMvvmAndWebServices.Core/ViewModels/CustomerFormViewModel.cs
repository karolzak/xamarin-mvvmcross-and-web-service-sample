using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamMvvmAndWebServices.Helpers;
using XamMvvmAndWebServices;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.ViewModels
{
    public class CustomerFormViewModel : MvxViewModel
    {

        public CustomerFormViewModel(IXamarinMVVMSampleWebAPI apiService)
        {
            _apiService = apiService;
        }

        //used to pass in navigation parameters
        public async void Init(NavigationParameters param)
        {
            NavParam = param;

            if (param.IsNew)
            {
                //Employee = await _apiService.Employees.GetEmployeeAsync(param.EmployeeId);
                PageTitle = "New customer";
                Customer = new Customer();
                Customer.EmployeeId = param.EmployeeId;
            }
            else
            {
                PageTitle = "Edit customer";
                Customer = await _apiService.Customers.GetCustomerAsync(param.CustomerId);
            }
        }

        #region Properties

        private string _pageTitle = "Customer";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        private NavigationParameters _navParam;
        public NavigationParameters NavParam
        {
            get { return _navParam; }
            set { SetProperty(ref _navParam, value); }
        }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set { SetProperty(ref _customer, value); }
        }


        private IXamarinMVVMSampleWebAPI _apiService;

        #endregion

        #region Commands
        private MvxCommand<object> _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand<object>(GoBack);
                return _goBackCommand;
            }
        }

        private MvxCommand<object> _discardCommand;
        public ICommand DiscardCommand
        {
            get
            {
                _discardCommand = _discardCommand ?? new MvxCommand<object>(DiscardForm);
                return _discardCommand;
            }
        }

        private MvxCommand<object> _saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                _saveCommand = _saveCommand ?? new MvxCommand<object>(SaveForm);
                return _saveCommand;
            }
        }

        #endregion

        #region Methods

        private void GoBack(object param)
        {
            Close(this);
        }

        private async void SaveForm(object param)
        {
            if (NavParam.IsNew)
            {
                Customer.DateJoined = DateTime.Now;
                Customer = await _apiService.Customers.PostCustomerAsync(Customer);
            }
            else
            {
                await _apiService.Customers.PutCustomerAsync(NavParam.CustomerId, Customer);

            }
            GoBack(param);

        }
        private void DiscardForm(object param)
        {
            //TODO Add some logic and UI to verify if user really wants to discard form
            GoBack(param);
        }

        #endregion
    }
}