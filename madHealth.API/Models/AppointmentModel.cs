using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace madHealth.API.Models
{
    public class AppointmentModel
    {
        //public Appointment()
        //{
        //    DiagnosisList = new List<Diagnosis>();
        //    AnalysisList = new List<AnalysisResult>();
        //}

        public int Id { get; set; }
        public DateTime Date { get; set; }
        //public List<Diagnosis> DiagnosisList { get; set; }
        //public List<AnalysisResult> AnalysisList { get; set; }
        //public virtual Patient Patient { get; set; }
    }
}