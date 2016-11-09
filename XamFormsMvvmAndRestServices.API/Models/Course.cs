using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XamFormsMvvmAndRestServices.API.Models
{
    [DataContract(IsReference = true)]
    [JsonObject(IsReference =true)]
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        //[JsonIgnore]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}