using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB_CRUD
{
    public class MongoDB_CRUD
    {
        private readonly IMongoDatabase db;

        public MongoDB_CRUD()
        {
            //var client = new MongoClient(config.ConnectionString);
            var client = new MongoClient(@"mongodb://root:example@192.168.99.100:27017");
            var dbList = client.ListDatabases().ToList();
            foreach (var item in dbList)
            {
                Console.WriteLine(item);
            }
            //db = client.GetDatabase(config.Database);

        }

        public void GetCollection()
        { 
            
        }

        
    }
}
