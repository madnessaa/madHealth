using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Database
{
    public class Diagnosis:Basic
    {
        public int Id { get; set; }
        public string Name { get; set; }         
        public string Description { get; set; }
        public virtual DiagnosisType DiagnosisType { get; set; }
    }
}
