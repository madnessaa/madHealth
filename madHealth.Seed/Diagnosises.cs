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
    public class Diagnosises
    {
        public static void Get()
        {
            ImadHealthRepository<Diagnosis> diagnosises = new madHealthRepository<Diagnosis>(Help.Context); 
            DataTable rawData = Help.OpenExcel("Diagnosises");
            int N = 0;
            foreach (DataRow row in rawData.Rows)
            {
                int oldId = Help.getInteger(row, 0);
                Diagnosis diag = new Diagnosis()
                {
                    Name = Help.getString(row, 1),
                    Description = Help.getString(row,2),
                    Template = Help.getString(row,3),
                    AppointmentID = Help.getInteger (row,4)
                };
                N++;
                diagnosises.Insert(diag);
                diagnosises.Commit();
                Help.dicDiag.Add(oldId, diag.Id); 
            }

            Console.WriteLine(N);
        }
    }
}
