using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//using XamFormsMvvmAndRestServices.API.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace XamFormsMvvmAndRESTServices.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FirstView : MvvmCross.WindowsUWP.Views.MvxWindowsPage
    {
        public FirstView()
        {
            this.InitializeComponent();
        }

        private const string URL = "http://xamarinmvvmsamplewebapi.azurewebsites.net/";
        //private const string URL = "http://localhost:59734/";

        //private static async Task<IEnumerable<Employee>> GetAllEmployees()
        //{
        //    HttpClient client = GetClient();
        //    string result = await client.GetStringAsync(URL + "api/Employees");
        //    return JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
        //}
        //private static async Task<IEnumerable<Customer>> GetAllCustomers()
        //{
        //    HttpClient client = GetClient();
        //    string result = await client.GetStringAsync(URL + "api/Customers");
        //    return JsonConvert.DeserializeObject<IEnumerable<Customer>>(result);
        //}
        //private static async Task<IEnumerable<Order>> GetAllOrders()
        //{
        //    HttpClient client = GetClient();
        //    string result = await client.GetStringAsync(URL + "api/Orders");
        //    return JsonConvert.DeserializeObject<IEnumerable<Order>>(result);
        //}
        //private static async Task UpdateEmployee(Employee employee)
        //{
        //    HttpClient client = GetClient();
        //    await client.PutAsync(URL + "api/Employees" + employee.Id,
        //        new StringContent(
        //            JsonConvert.SerializeObject(employee),
        //            Encoding.UTF8, "application/json"));
        //}
        //private static async Task<Employee> AddEmployee(Employee employee)
        //{
        //    HttpClient client = GetClient();
        //    HttpResponseMessage response=await client.PostAsync(URL + "api/Employees",
        //        new StringContent(
        //            JsonConvert.SerializeObject(employee),
        //            Encoding.UTF8, "application/json"));
        //    var result = await response.Content.ReadAsStringAsync();
        //    return JsonConvert.DeserializeObject<Employee>(result);

        //}
        //private static HttpClient GetClient()
        //{
        //    HttpClient client = new HttpClient();
        //    client.DefaultRequestHeaders.Add("APPID", "29e7fa6830fc67f2bf7d2745412e5b04");
        //    client.DefaultRequestHeaders.Add("Accept", "application/json");
        //    return client;
        //}
        //private static async Task<IEnumerable<Student>> GetAllStudents()
        //{
        //    HttpClient client = GetClient();
        //    string result = await client.GetStringAsync(URL + "api/Students");
        //    return JsonConvert.DeserializeObject<IEnumerable<Student>>(result);
        //}
        //private static async Task<IEnumerable<Student>> GetStudent(int i)
        //{
        //    HttpClient client = GetClient();
        //    string result = await client.GetStringAsync(URL + "api/Students/"+i);
        //    return JsonConvert.DeserializeObject<IEnumerable<Student>>(result);
        //}


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            XamarinMVVMSampleWebAPIService webApiClient = new XamarinMVVMSampleWebAPIService();
            var studs= webApiClient.Students.GetStudents();



            //HttpClient client = GetClient();
            //string result = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/forecast/daily?q=Warsaw,PL&cnt=15&APPID=39068ef62781908b106fb91550441325");
            //JsonConvert.DeserializeObject<IEnumerable<Student>>(result);
            //var stud = await GetStudent(1);
            //var studs = await GetAllStudents();

            //var employees = await GetAllEmployees();


            //var emp =await AddEmployee(new Employee()
            //{
            //    FirstName = "Karol",
            //    LastName="Żak"
                
            //});

            //var customers = await GetAllCustomers();
            //var orders = await GetAllOrders();

            //foreach (var item in customers)
            //{
            //    var emp = employees.Where(x => x.ID == item.EmployeeID).Single();
            //    emp.Customers = new List<Customer>(); 
            //       emp.Customers.Add(item);
            //    await UpdateEmployee(emp);
            //}

            
        }
    }
}
