using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace madHealth.API.Models
{
    public class PatientModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MaidenName { get; set; }
        public string FathersName { get; set; }
        public DateTime BirthDate { get; set; }
        public string UniqueID { get; set; }
        //public MarritialStatus Married { get; set; }
    }
}