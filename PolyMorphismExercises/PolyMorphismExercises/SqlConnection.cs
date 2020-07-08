using System;

namespace PolyMorphismExercises
{
    class SqlConnection : DbConnection
    {

        public SqlConnection(string sqlConnString)
            : base(sqlConnString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Opening Sql Database with connection string: " + this.ConnString);
        }
        public override void Open(TimeSpan timeOut)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            Console.WriteLine("Closing Sql Database");

        }
    }
}
