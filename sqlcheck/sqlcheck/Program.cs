using System.Data;
using System.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataSourceEnumerator sqldatasourceenumerator1 = SqlDataSourceEnumerator.Instance;
            DataTable datatable1 = sqldatasourceenumerator1.GetDataSources();
            foreach (DataRow row in datatable1.Rows)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("Server Name:" + row["ServerName"]);
                Console.WriteLine("Instance Name:" + row["InstanceName"]);
                Console.WriteLine("Is Clustered:" + row["IsClustered"]);
                Console.WriteLine("Version:" + row["Version"]);
                Console.WriteLine("****************************************");
            }
        }
    }
}
