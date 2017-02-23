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

        #region Properties
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

        private string _pageTitle = "Employee";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }
        #endregion

        //SHOW: Navigation - retrieve parameters
        //used to pass in navigation parameters
        public async void Init(NavigationParameters param)
        {
            NavParam = param;
            if (param.IsNew)
            {
                PageTitle = "New employee";
                Employee = new Employee();
            }
            else
            {
                PageTitle = "Edit employee";
                Employee = await _apiService.Employees.GetEmployeeAsync(param.EmployeeId);
            }
        }

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

        private  void GoBack(object param)
        {
           
            Close(this);
        }
        private async void SaveForm(object param)
        {
                if (NavParam.IsNew)
                {
                    Employee = await _apiService.Employees.PostEmployeeAsync(Employee);
                }
                else
                {
                    await _apiService.Employees.PutEmployeeAsync(NavParam.EmployeeId, Employee);

                }

            Close(this);
        }
        private  void DiscardForm(object param)
        {
            
            Close(this);
        }
    }
}
