using System;

namespace PolyMorphismExercises
{
    abstract class DbConnection
    {
        public string ConnString { get; private set; }
        public TimeSpan TimeOut { get; set; }
        public DbConnection(string dbConn)
        {
            if (String.IsNullOrWhiteSpace(dbConn))
                throw new Exception("Connection String must not be empty or null");
            ConnString = dbConn;
        }

        public abstract void Open();
        public abstract void Open(TimeSpan timeOut);

        public abstract void Close();
    }
}
