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
