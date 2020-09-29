using ffc_backend.Model;
using ffc_backend.Model.database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ffc_backend.FccDBApi
{
    public class DBConnectionService
    {
        private readonly IDBConnectionSettings mDBConnectionSettings;

        private readonly IMongoCollection<EventMeta> _books;

        public DBConnectionService(IDBConnectionSettings connectionSettings)
        {
            mDBConnectionSettings = connectionSettings;

            var client = new MongoClient(mDBConnectionSettings.connectionString);
            var database = client.GetDatabase(mDBConnectionSettings.databaseName);

            _books = database.GetCollection<EventMeta>(mDBConnectionSettings.collectionName);
        }
    }
}
