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
    public class EmployeeFormViewModel:MvxViewModel
    {
        private IXamarinMVVMSampleWebAPI _apiService;

        public EmployeeFormViewModel(IXamarinMVVMSampleWebAPI apiService)
        {
            _apiService = apiService;
        }

        private NavigationParameters _navParam;
        public NavigationParameters NavParam
        {
            get { return _navParam; }
            set { SetProperty(ref _navParam, value); }
        }

        private Employee _employee;
        public Employee Employee
        {
            get { return _employee; }
            set { SetProperty(ref _employee, value); }
        }


       
        //SHOW: Navigation - retrieve parameters
        //used to pass in navigation parameters
        public async void Init(NavigationParameters param)
        {
            NavParam = param;
            if(param.IsNew)
            {
                Employee = new Employee();
            }
                else
            Employee = await _apiService.Employees.GetEmployeeAsync(param.EmployeeId);
        }

        #region Commands
        private MvxCommand<string> _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand<string>(async (param) => await GoBack(param));
                return _goBackCommand;
            }
        }

        #endregion

        private async Task GoBack(string param)
        {
            if (param=="save")
            {
                if (NavParam.IsNew)
                {
                    Employee= await _apiService.Employees.PostEmployeeAsync(Employee);
                }
                else
                {
                     await _apiService.Employees.PutEmployeeAsync(NavParam.EmployeeId, Employee);
                    
                }
            }
            
            Close(this);
        }
    }
}
