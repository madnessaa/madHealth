using madHealth.Database;
using madHealth.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Seed
{
    public class Patients
    {
        public static void Get()
        {
            ImadHealthRepository<Patient> patients = new madHealthRepository<Patient>(Help.Context);            
            DataTable rawData = Help.OpenExcel("Patients");
            int N = 0;
            foreach (DataRow row in rawData.Rows)
            {
                int oldId = Help.getInteger(row, 0); 
                Patient pat = new Patient()
                {
                    Name = Help.getString(row, 1),
                    Surname = Help.getString(row, 2),
                    MaidenName = Help.getString(row, 3),
                    FathersName = Help.getString(row, 4),
                    BirthDate = Help.getDate(row, 5),
                    UniqueID = Help.getString(row, 6),
                    Married = (MarritialStatus)Help.getInteger(row,7)
                };
                N++;
                patients.Insert(pat);
                patients.Commit();
                Help.dicPatient.Add(oldId, pat.Id);
            }
            Console.WriteLine(N);
        }
    }
}
