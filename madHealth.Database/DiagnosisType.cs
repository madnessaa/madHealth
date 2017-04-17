using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Database
{
    public class DiagnosisType:Basic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Template { get; set; } 
    }
}
