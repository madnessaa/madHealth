using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madHealth.Database
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            System.Data.Entity.Database.SetInitializer<TContext>(null);

        }

        protected BaseContext()
            : base("name=MadHealth") { }
    }
}
