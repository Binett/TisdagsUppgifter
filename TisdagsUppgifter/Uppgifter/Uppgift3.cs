using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TisdagsUppgifter.Uppgifter
{
    class Uppgift3
    {
        public static void Run()
        {
            var dataBase = new SQLDatabse("Population");
            var sql = "SELECT * FROM People WHERE age >@age1 AND age<@age2";
            Console.WriteLine("Ange åldrar:");
            var age1 = Console.ReadLine();
            var age2 = Console.ReadLine();
            var dataTable = dataBase.GetDataTable(sql,("@age1",age1),("@age2",age2));
        

            foreach (DataRow row in dataTable.Rows)
            {
                //Console.WriteLine(row["Namn"]);
                foreach  (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine($"{row[column]}, ");
                }
            }
        }
    }
}
