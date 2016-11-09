using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace XamFormsMvvmAndRestServices.API.Models
{

    [DataContract(IsReference = true)]
    [JsonObject(IsReference = true)]
    [Table("Employees")]
    public class Employee
    {
        //public Employee()
        //{
        //    Customers = new List<Customer>();
        //}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[JsonIgnore]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}