using madHealth.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Seed
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Data migration in progress");
            Console.WriteLine("--------------------------");            
            AnalysisTypes.Get();
            AnalysisResults.Get();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
