using System;

namespace PolyMorphismExercises
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string oracleConnString)
            : base(oracleConnString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle Database with connection string: " + this.ConnString);
        }

        public override void Open(TimeSpan timeOut)
        {
            Console.WriteLine("Opening Oracle Database with connection string: " + this.ConnString);
            this.TimeOut = timeOut;
            Console.WriteLine("Set time out to : " + timeOut);
        }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle Database Connection");
        }

    }
}
