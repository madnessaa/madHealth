using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Context();
    
            AnalysisType tip = new AnalysisType();

            tip.Id = Convert.ToInt32(Console.ReadLine());
            tip.Title = Console.ReadLine();

            db.AnalysisTypes.Add(tip);

            //Console.WriteLine(tip.Id);
            // tip.Title = Console.ReadLine();


            //Console.WriteLine(id);

            try
            {
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {

            }

        }
    }
}
