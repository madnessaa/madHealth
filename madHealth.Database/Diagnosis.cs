using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace madHealth.Database
{
    [Table("Diagnosises")]
    public class Diagnosis:Basic
    {
        public int Id { get; set; }
        public string Name { get; set; }         
        public string Description { get; set; }
        public string Template { get; set; }
        public virtual int AppointmentID { get; set; } 
    }
}
