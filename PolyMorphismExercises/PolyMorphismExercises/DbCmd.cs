using System;
using System.Threading;

namespace PolyMorphismExercises
{
    class DbCmd
    {
        public DbConnection dbConnection;
        private string instruction { get; set; }
        public DbCmd(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new Exception("dbConnection must not be null");
            if (String.IsNullOrWhiteSpace(instruction))
                throw new Exception("instructions can't be null");
            this.dbConnection = dbConnection;
            this.instruction = instruction;
        }

        public void Execute()
        {
            this.dbConnection.Open();
            Console.WriteLine(instruction);
            Thread.Sleep(dbConnection.TimeOut);
            this.dbConnection.Close();
        }
    }
}
