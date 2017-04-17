using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Database
{
    public class Patient:Basic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MaidenName { get; set; }
        public string FathersName { get; set; }
        public DateTime BirthDate { get; set; }
        public string UniqueID { get; set; }
        public MarritialStatus Married { get; set; }
    }
}
