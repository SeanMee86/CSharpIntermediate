using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace MongoConnect
{
    class DataBase
    {
        private readonly string mongoDbString = "mongodb+srv://seanmee86:Munchen*86@wbcluster-nxeyu.mongodb.net/workout-builder?retryWrites=true&w=majority";
        
        private MongoClient GetConnection()
        {
            return new MongoClient(mongoDbString);
        }

        public void RunQuery()
        {
            var collectionToQuery = Console.ReadLine();
            var dbClient = GetConnection();
            var dbList = dbClient.ListDatabases().ToList();
            var database = dbClient.GetDatabase("workout-builder");
            var collection = database.GetCollection<BsonDocument>(collectionToQuery);

            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }

            var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();
            var json = JsonConvert.SerializeObject(firstDocument, Formatting.Indented);
            Console.WriteLine(json);
        }        
    }
}
