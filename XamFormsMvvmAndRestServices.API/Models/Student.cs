using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XamFormsMvvmAndRestServices.API.Models
{
    [DataContract(IsReference = true)]
    [JsonObject(IsReference = true)]
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //[JsonIgnore]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}