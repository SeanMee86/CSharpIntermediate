namespace MongoConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            var mongoDb = new DataBase();
            //mongoDb.RunQuery();
            var mysql = new MySQLConnect();
            mysql.MySQLMainMethod();
        }
    }
}
