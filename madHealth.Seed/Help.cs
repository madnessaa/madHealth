﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using madHealth.Database;

namespace madHealth.Seed
{
    class Help
    {
        public static Context Context = new Context();
        public static string SourceRoot = @"..\..\..\madHealth.xls";

        public static Dictionary<int, int> dicARes = new Dictionary<int, int>();
        public static Dictionary<int, int> dicATypes = new Dictionary<int, int>();
        public static Dictionary<int, int> dicDiag = new Dictionary<int, int>();
        public static Dictionary<int, int> dicPatient = new Dictionary<int, int>();
        public static Dictionary<int, int> dicAppt = new Dictionary<int, int>(); 


        public static DataTable OpenExcel(string sheet)
        {
            var cs = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0", SourceRoot);
            OleDbConnection conn = new OleDbConnection(cs);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM [{0}$]", sheet), conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            Console.Write($"{sheet}: ");
            return dt;
        }

        public static string getString(DataRow row, int index)
        {
            return row.ItemArray.GetValue(index).ToString();
        }

        public static int getInteger(DataRow row, int index)
        {
            return Convert.ToInt32(row.ItemArray.GetValue(index).ToString());
        }

        public static DateTime getDate(DataRow row, int index)
        {
            return Convert.ToDateTime(row.ItemArray.GetValue(index).ToString());
        }

        public static double getDouble(DataRow row, int index)
        {
            return Convert.ToDouble(row.ItemArray.GetValue(index).ToString());
        }
    }
}
