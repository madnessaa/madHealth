using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace madHealth.API.Models
{
    public class DiagnosisModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Template { get; set; }
       // public virtual int AppointmentID { get; set; }
    }
}