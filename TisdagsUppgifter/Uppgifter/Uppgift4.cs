using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TisdagsUppgifter.Uppgifter
{
    class Uppgift4
    {
        public static void Run()
        {
            var db = new SQLDatabse();
            var sql = "SELECT physical_name,size FROM sys.database_files";
            var dt = db.GetDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                //Console.WriteLine(row["physical_name"]);
                foreach (DataColumn column in dt.Columns)
                {
                    Console.Write($"{row[column]}, ");
                }
            }
        }
    }
}
