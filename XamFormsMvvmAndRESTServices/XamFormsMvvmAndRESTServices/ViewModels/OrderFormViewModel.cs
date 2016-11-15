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
    public class OrderFormViewModel : MvxViewModel
    {
        private NavigationParameters _navParam;
        public NavigationParameters NavParam
        {
            get { return _navParam; }
            set { SetProperty(ref _navParam, value); }
        }

        private Order _order;
        public Order Order
        {
            get { return _order; }
            set { SetProperty(ref _order, value); }
        }


        private IXamarinMVVMSampleWebAPI _apiService;

        public OrderFormViewModel(IXamarinMVVMSampleWebAPI apiService)
        {
            _apiService = apiService;
        }

        //used to pass in navigation parameters
        public async void Init(NavigationParameters param)
        {
            NavParam = param;
            if (param.IsNew)
            {
                Order = new Order();
                Order.CustomerId = param.CustomerId;
            }
            else
                Order = await _apiService.Orders.GetOrderAsync(param.OrderId);
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
                    Order = await _apiService.Orders.PostOrderAsync(Order);
                }
                else
                {
                    await _apiService.Orders.PutOrderAsync(NavParam.OrderId, Order);

                }
            }

            Close(this);
        }
    }
}
