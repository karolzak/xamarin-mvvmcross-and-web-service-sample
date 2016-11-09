using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using XamFormsMvvmAndRESTServices.Models;

namespace XamFormsMvvmAndRESTServices.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private IXamarinMVVMSampleWebAPIService _apiService;

        public FirstViewModel(IXamarinMVVMSampleWebAPIService apiService)
        {
            _apiService = apiService;

            //Employee newEmp = new Employee()
            //{
            //    FirstName = "Karol",
            //    LastName = "¯ak",
            //    Customers = new List<Customer>()
            //     {
            //         new Customer()
            //         {
            //             CustomerName="FarmaPol",
            //              City="Warszawa",
            //               DateJoined=DateTime.Now.AddYears(-4),
            //                Address="ul. Romera 10",
            //                 TelNumber="353-767-345"

            //         },
            //          new Customer()
            //         {
            //             CustomerName="Madziar Sp. z o.o.",
            //              City="Warszawa",
            //               DateJoined=DateTime.Now.AddYears(-4),
            //                Address="ul. Grójecka 34",
            //                 TelNumber="764-244-902"

            //         },
            //           new Customer()
            //         {
            //             CustomerName="MiniSoft",
            //              City="Poznañ",
            //               DateJoined=DateTime.Now.AddYears(-4),
            //                Address="ul. Warszawska 103",
            //                 TelNumber="673-121-846"

            //         },
            //     }
            //};
            //Employee newEmp = new Employee()
            //{
            //    FirstName = "Tomasz",
            //    LastName = "Wiœniewski",
            //    Customers = new List<Customer>()
            //     {
            //         new Customer()
            //         {
            //             CustomerName="Future Proces",
            //              City="Gliwice",
            //               DateJoined=DateTime.Now.AddYears(-2),
            //                Address="ul. Mariacka 50",
            //                 TelNumber="353-767-345"

            //         },
            //          new Customer()
            //         {
            //             CustomerName="Seccaco Sp z o.o.",
            //              City="Kraków",
            //               DateJoined=DateTime.Now.AddYears(-1),
            //                Address="ul. Warszawska 140",
            //                 TelNumber="764-244-902"

            //         },
            //           new Customer()
            //         {
            //             CustomerName="MakroSoft PL",
            //              City="Bydgoszcz",
            //               DateJoined=DateTime.Now.AddYears(-4),
            //                Address="ul. Warszawska 11",
            //                 TelNumber="673-121-846"

            //         },
            //     }
            //};

            // var emp= _apiService.Employees.PostEmployee(newEmp);


            //var employee = _apiService.Employees.GetEmployees();
            //var customers=employee[0].Customers;
        }

        #region Properties

        private string _pageTitle = "Hello to FirstView";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }
        #endregion

        #region Commands
        private MvxCommand _navigateToCustomersCommand;
        public ICommand NavigateToCustomersCommand
        {
            get
            {
                _navigateToCustomersCommand = _navigateToCustomersCommand ?? new MvxCommand(() =>  NavigateToCustomers());
                return _navigateToCustomersCommand;
            }
        }

        private void NavigateToCustomers()
        {
            ShowViewModel<CustomersViewModel>();
            //ShowViewModel<OrdersViewModel>();
        }

        #endregion

    }
}
