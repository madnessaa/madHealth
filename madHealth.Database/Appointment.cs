using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace madHealth.Database
{
    public class Appointment:Basic
    {
        public Appointment()
        {
            DiagnosisList = new List<Diagnosis>();
            AnalysisList = new List<AnalysisResult>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }        
        public List<Diagnosis> DiagnosisList { get; set; }
        public List<AnalysisResult> AnalysisList { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
