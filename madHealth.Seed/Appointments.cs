using madHealth.Database;
using madHealth.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Seed
{
    public class Appointments
    {
        public static void Get()
        {
            ImadHealthRepository<Appointment> appointments = new madHealthRepository<Appointment>(Help.Context);
            ImadHealthRepository<Patient> patients = new madHealthRepository<Patient>(Help.Context);           

            DataTable rawData = Help.OpenExcel("Appointments");
            int N = 0;
            foreach (DataRow row in rawData.Rows)
            {
                int oldId = Help.getInteger(row, 0);
                int patient = Help.getInteger(row, 2);
                Patient pat = patients.Get().FirstOrDefault(x => x.Id == patient);    
                Appointment appt = new Appointment() 
                {
                    Date = Help.getDate(row, 1),
                    Patient = pat,                    
                };
                N++;
                appointments.Insert(appt);
                appointments.Commit();
                Help.dicAppt.Add(oldId, appt.Id);
            }
            Console.WriteLine(N);
        }
    }
}
