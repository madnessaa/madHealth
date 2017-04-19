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
    public class AnalysisTypes
    {
        public static void Get()
        {
            ImadHealthRepository<AnalysisType> analysistypes = new madHealthRepository<AnalysisType>(Help.Context);
            DataTable rawData = Help.OpenExcel("AnalysisTypes");
            int N = 0;
            foreach (DataRow row in rawData.Rows)
            {
                int oldId = Help.getInteger(row, 0);
                AnalysisType atypes = new AnalysisType()
                {
                    Title = Help.getString(row, 1),
                };
                N++;
                analysistypes.Insert(atypes);
                analysistypes.Commit();
                Help.dicATypes.Add(oldId, atypes.Id);
            }

            Console.WriteLine(N);
        }

    }
}

