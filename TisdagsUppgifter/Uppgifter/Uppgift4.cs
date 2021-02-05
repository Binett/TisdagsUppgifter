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
            db.GetFilePath();
        }
    }
}
