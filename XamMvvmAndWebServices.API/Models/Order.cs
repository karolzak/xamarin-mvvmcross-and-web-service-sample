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
    [Table("Orders")]
    public class Order
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public string ProductName { get; set; }

        public int CustomerId { get; set; }
        //[JsonIgnore]
        public virtual Customer Customer { get; set; }

    }
}