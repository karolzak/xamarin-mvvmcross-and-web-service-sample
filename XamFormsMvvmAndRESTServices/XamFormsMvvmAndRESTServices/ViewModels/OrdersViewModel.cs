using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamFormsMvvmAndRESTServices.Helpers;
using XamFormsMvvmAndRESTServices.ViewModels;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.ViewModels
{
    public class OrdersViewModel : MvxViewModel
    {

        private string _pageTitle = "Orders";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set { SetProperty(ref _customer, value); }
        }

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set { SetProperty(ref _selectedOrder, value); }
        }

        private IXamarinMVVMSampleWebAPI _apiService;

        public OrdersViewModel(IXamarinMVVMSampleWebAPI apiService)
        {
            _apiService = apiService;
        }

        //used to pass in navigation parameters
        public void Init(NavigationParameters param)
        {
            Customer = _apiService.Customers.GetCustomer(param.CustomerId);
            if (Customer.Orders.Count > 0 & SelectedOrder == null)
                SelectedOrder = Customer.Orders[0];
        }



        #region Commands
        private MvxCommand<string> _addEditCommand;
        public ICommand AddEditCommand
        {
            get
            {
                _addEditCommand = _addEditCommand ?? new MvxCommand<string>((param) => AddEdit(param));
                return _addEditCommand;
            }
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
        #endregion

        #region Methods
        private void AddEdit(string param)
        {
            if (param == "add")
            {
                ShowViewModel<OrderFormViewModel>(new NavigationParameters() { IsNew = true, CustomerId = (int)_customer.Id });
            }
            else if (param == "edit")
            {

                ShowViewModel<OrderFormViewModel>(new NavigationParameters() { OrderId = (int)_selectedOrder.Id });
            }

        }

        private void GoBack()
        {
            Close(this);
        }

        #endregion
    }
}
