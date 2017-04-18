using madHealth.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Repository
{
    public class UnitOfWork:IDisposable
    {

        private readonly Context _context = new Context();

        private ImadHealthRepository<Appointment> _appointments;
        private ImadHealthRepository<Patient> _patients;
        private ImadHealthRepository<Diagnosis> _diagnosises; 
        private ImadHealthRepository<AnalysisResult> _analysisresults;
        private ImadHealthRepository<AnalysisType> _analysistypes;

        public Context Context { get { return _context; } }

        public ImadHealthRepository<Appointment> Appointments { get { return _appointments ?? (_appointments = new madHealthRepository<Appointment>(_context)); } }
        public ImadHealthRepository<Patient> Patients { get { return _patients ?? (_patients = new madHealthRepository<Patient>(_context)); } }
        public ImadHealthRepository<Diagnosis> Diagnosises { get { return _diagnosises ?? (_diagnosises = new madHealthRepository<Diagnosis>(_context)); } }
        public ImadHealthRepository<AnalysisResult> AnalysisResults { get { return _analysisresults ?? (_analysisresults = new madHealthRepository<AnalysisResult>(_context)); } }
        public ImadHealthRepository<AnalysisType> AnalysisTypes { get { return _analysistypes ?? (_analysistypes = new madHealthRepository<AnalysisType>(_context)); } }


        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
