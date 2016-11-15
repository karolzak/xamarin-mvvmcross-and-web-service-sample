using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamFormsMvvmAndRESTServices.Helpers;
using XamMvvmAndWebServices;
using XamMvvmAndWebServices.Models;

namespace XamFormsMvvmAndRESTServices.ViewModels
{
    public class CustomerFormViewModel : MvxViewModel
    {
        private NavigationParameters _navParam;
        public NavigationParameters NavParam
        {
            get { return _navParam; }
            set { SetProperty(ref _navParam, value); }
        }

        //private Employee _employee;
        //public Employee Employee
        //{
        //    get { return _employee; }
        //    set { SetProperty(ref _employee, value); }
        //}
        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set { SetProperty(ref _customer, value); }
        }


        private IXamarinMVVMSampleWebAPI _apiService;

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
                Customer = new Customer();
                Customer.EmployeeId = param.EmployeeId;
            }
            else
                Customer = await _apiService.Customers.GetCustomerAsync(param.CustomerId);
        }


        private MvxCommand<string> _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand<string>(async (param) => await GoBack(param));
                return _goBackCommand;
            }
        }

        private async Task GoBack(string param)
        {
            if (param == "save")
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
            }

            Close(this);
        }
    }
}
