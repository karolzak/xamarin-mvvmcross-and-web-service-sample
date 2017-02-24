using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamMvvmAndWebServices.Helpers
{
    //SHOW: Navigation parameters
    public class NavigationParameters
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsNew { get; set; }
    }
}
