using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Database
{
    public class AnalysisResult:Basic
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public AnalysisStatus Status { get; set; }
        public AnalysisType Type { get; set; }
        public string Description { get; set; } 
    }
}
