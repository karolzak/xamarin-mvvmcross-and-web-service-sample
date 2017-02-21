using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamMvvmAndWebServices.Helpers;
using XamMvvmAndWebServices.ViewModels;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.ViewModels
{
    public class CustomersViewModel : MvxViewModel
    {
        private string _pageTitle = "Customers";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        private Employee _employee;
        public Employee Employee
        {
            get { return _employee; }
            set { SetProperty(ref _employee, value); }
        }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set { SetProperty(ref _selectedCustomer, value); }
        }

        public ObservableCollection<Customer> Customers { get; private set; }
        private IXamarinMVVMSampleWebAPI _apiService;

        public CustomersViewModel(IXamarinMVVMSampleWebAPI apiService)
        {
            _apiService = apiService;
            
        }

        //used to pass in navigation parameters
        public void Init(NavigationParameters param)
        {
            Employee = _apiService.Employees.GetEmployee(param.EmployeeId);
            Customers = new ObservableCollection<Customer>();

            var customers = _apiService.Customers.GetCustomers().Where(q=>q.EmployeeId==Employee.Id);
            foreach (var cust in customers)
            {
                if (SelectedCustomer == null)
                    SelectedCustomer = cust;
                Customers.Add(cust);
            }

        }

        #region Commands

        private MvxCommand<string> _addEditCommand;
        public ICommand AddEditCommand
        {
            get
            {
                _addEditCommand = _addEditCommand ?? new MvxCommand<string>(AddEdit);
                return _addEditCommand;
            }
        }

        private MvxCommand<object> _navigateToOrdersCommand;
        public ICommand NavigateToOrdersCommand
        {
            get
            {
                _navigateToOrdersCommand = _navigateToOrdersCommand ?? new MvxCommand<object>( NavigateToOrders);
                return _navigateToOrdersCommand;
            }
        }


        private MvxCommand _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand( GoBack);
                return _goBackCommand;
            }
        }
#endregion
        #region Methods
        private void AddEdit(string param)
        {
            if (param == "add")
            {
                ShowViewModel<CustomerFormViewModel>(new NavigationParameters() { IsNew = true, EmployeeId = (int)_employee.Id });
            }
            else if (param == "edit")
            {

                ShowViewModel<CustomerFormViewModel>(new NavigationParameters() { CustomerId = (int)_selectedCustomer.Id});
            }

        }

        private void NavigateToOrders(object param)
        {
            //ShowViewModel<CustomersViewModel>();
            
            ShowViewModel<OrdersViewModel>(new NavigationParameters() { CustomerId = (int)(param as Customer).Id });
            // ShowViewModel<OrdersViewModel>();
        }

        private void GoBack()
        {
            Close(this);
        }
        #endregion
    }
}
