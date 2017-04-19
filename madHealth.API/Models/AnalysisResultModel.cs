using madHealth.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace madHealth.API.Models
{
    public class AnalysisResultModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public AnalysisStatus Status { get; set; }
        public int Type { get; set; }
        public virtual int AppointmentID { get; set; }
    }
}