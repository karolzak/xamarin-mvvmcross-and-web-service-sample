using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using XamMvvmAndWebServices.Helpers;
using XamMvvmAndWebServices.ViewModels;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.ViewModels
{
    //SHOW: VM inherit from MvxViewModel - implements INotifyPropertyChanged
    public class FirstViewModel 
        : MvxViewModel
    {
        private IXamarinMVVMSampleWebAPI _apiService;
        
        //SHOW: VM constructor used for dependency injection
        public FirstViewModel(IXamarinMVVMSampleWebAPI apiService)
        {

            _apiService = apiService;
            Employees = new ObservableCollection<Employee>();

            var emps = _apiService.Employees.GetEmployees();
            foreach (var emp in emps)
            {
                Employees.Add(emp);
                if (SelectedEmployee == null)
                    SelectedEmployee = emp;
            }
          //  Seed();
        }

        private void Seed()
        {

            Employee newEmp1 = new Employee()
            {
                FirstName = "Karol",
                LastName = "¯ak",
                Customers = new List<Customer>()
                 {
                     new Customer()
                     {
                         CustomerName="FarmaPol",
                          City="Warszawa",
                           DateJoined=DateTime.Now.AddYears(-4),
                            Address="ul. Romera 10",
                             TelNumber="353-767-345"

                     },
                      new Customer()
                     {
                         CustomerName="Madziar Sp. z o.o.",
                          City="Warszawa",
                           DateJoined=DateTime.Now.AddYears(-4),
                            Address="ul. Grójecka 34",
                             TelNumber="764-244-902"

                     },
                       new Customer()
                     {
                         CustomerName="MiniSoft",
                          City="Poznañ",
                           DateJoined=DateTime.Now.AddYears(-4),
                            Address="ul. Warszawska 103",
                             TelNumber="673-121-846"

                     },
                 }
            };

            var emp1 = _apiService.Employees.PostEmployeeAsync(newEmp1);
            Employee newEmp2 = new Employee()
            {
                FirstName = "Tomasz",
                LastName = "Wiœniewski",
                Customers = new List<Customer>()
                 {
                     new Customer()
                     {
                         CustomerName="Future Proces",
                          City="Gliwice",
                           DateJoined=DateTime.Now.AddYears(-2),
                            Address="ul. Mariacka 50",
                             TelNumber="353-767-345"

                     },
                      new Customer()
                     {
                         CustomerName="Seccaco Sp z o.o.",
                          City="Kraków",
                           DateJoined=DateTime.Now.AddYears(-1),
                            Address="ul. Warszawska 140",
                             TelNumber="764-244-902"

                     },
                       new Customer()
                     {
                         CustomerName="MakroSoft PL",
                          City="Bydgoszcz",
                           DateJoined=DateTime.Now.AddYears(-4),
                            Address="ul. Warszawska 11",
                             TelNumber="673-121-846"

                     },
                 }
            };

            var emp = _apiService.Employees.PostEmployeeAsync(newEmp2);


            var Employee =  _apiService.Employees.GetEmployeesAsync();
        }

        #region Properties
        //SHOW: VM Properties
        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { SetProperty(ref _selectedEmployee, value); }
        }


        public ObservableCollection<Employee> Employees { get; private set; }

        private string _pageTitle = "Employees";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }
        #endregion

        #region Commands
        //SHOW: VM Commands
        private MvxCommand<string> _addEditCommand;
        public ICommand AddEditCommand
        {
            get
            {
                _addEditCommand = _addEditCommand ?? new MvxCommand<string>((param) => AddEdit(param));
                return _addEditCommand;
            }
        }
        private MvxCommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                _addCommand = _addCommand ?? new MvxCommand(() => AddEdit("add"));
                return _addCommand;
            }
        }
        private MvxCommand _editCommand;
        public ICommand EditCommand
        {
            get
            {
                _editCommand = _editCommand ?? new MvxCommand(() => AddEdit("edit"));
                return _editCommand;
            }
        }



        private MvxCommand _navigateToCustomersCommand;
        public ICommand NavigateToCustomersCommand
        {
            get
            {

                _navigateToCustomersCommand = _navigateToCustomersCommand ?? new MvxCommand(() => NavigateToCustomers());

                return _navigateToCustomersCommand;
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

        private MvxCommand _getEmployees;
        public ICommand GetEmployeesCommand
        {
            get
            {
                _getEmployees = _getEmployees ?? new MvxCommand(async () => await GetEmployees());

                return _getEmployees;
            }
        }

        #endregion

        #region Methods
        //SHOW: VM Methods
        private async Task GetEmployees()
        {
            var Employee = await _apiService.Employees.GetEmployeesAsync();
        }

        private void NavigateToCustomers()
        {
            //SHOW: Navigation - passing parameters
            ShowViewModel<CustomersViewModel>(new NavigationParameters() { EmployeeId=(int)_selectedEmployee.Id});
            //ShowViewModel<EmployeesViewModel>();
        }
        private void AddEdit(string param)
        {
            
            if (param == "add")
            {
                ShowViewModel<EmployeeFormViewModel>(new NavigationParameters() { IsNew=true });
            }
            else if(param == "edit")
            {

                ShowViewModel<EmployeeFormViewModel>(new NavigationParameters() { EmployeeId = (int)_selectedEmployee.Id });
            }
            
        }
        private void GoBack()
        {
            Close(this);
        }

        #endregion
    }
}
