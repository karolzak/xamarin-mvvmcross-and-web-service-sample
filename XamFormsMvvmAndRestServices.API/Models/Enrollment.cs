using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XamFormsMvvmAndRestServices.API.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    [DataContract(IsReference = true)]
    [JsonObject(IsReference = true)]
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        //[JsonIgnore]
        public virtual Course Course { get; set; }
        //[JsonIgnore]
        public virtual Student Student { get; set; }
    }

}