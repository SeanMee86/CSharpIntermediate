using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = new SqlConnection("server=sqlServer");
            //sqlConn.TimeOut = new TimeSpan(0,0,5);
            //sqlConn.Open();
            //Thread.Sleep(sqlConn.TimeOut);
            //sqlConn.Close();
            //var oracleConn = new OracleConnection("server=oracleServer");
            //oracleConn.Open(new TimeSpan(0, 0, 5));
            //Thread.Sleep(oracleConn.TimeOut);
            //oracleConn.Close();
            var dbCommand = new DbCmd(sqlConn, "Sending to Sql Server.");
            dbCommand.dbConnection.TimeOut = new TimeSpan(0, 0, 5);
            dbCommand.Execute();
        }
    }
}
