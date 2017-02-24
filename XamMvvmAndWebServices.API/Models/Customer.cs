using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace XamMvvmAndWebServices.API.Models
{

    [DataContract(IsReference = true)]
    [JsonObject(IsReference = true)]
    [Table("Customers")]
    public class Customer
    {
        //public Customer() { Orders = new List<Order>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("Name")]
        public string CustomerName { get; set; }
        
        public DateTime DateJoined { get; set; }

        public string City { get; set; }
        public string Address { get; set; }
                
        public string TelNumber { get; set; }
        //Foreign key for Employee
        public int EmployeeId { get; set; }
        //[JsonIgnore]
        public virtual Employee Employee { get; set; }
        //[JsonIgnore]
        [Column("Orders")]

        public virtual ICollection<Order> Orders { get; set; }
    }
}