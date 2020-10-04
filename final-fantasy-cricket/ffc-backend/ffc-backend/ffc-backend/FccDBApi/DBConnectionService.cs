using ffc_backend.Model.collection;
using ffc_backend.Model.database;
using MongoDB.Driver;

namespace ffc_backend.FccDBApi
{
    public class DBConnectionService
    {
        private readonly IDBConnectionSettings mDBConnectionSettings;

        private readonly IMongoCollection<EventMeta> event_meta_templates;
        private readonly IMongoCollection<User> user_collection;

        public DBConnectionService(IDBConnectionSettings connectionSettings)
        {
            mDBConnectionSettings = connectionSettings;

            var client = new MongoClient(mDBConnectionSettings.connectionString);
            var database = client.GetDatabase(mDBConnectionSettings.databaseName);

            user_collection = database.GetCollection<User>("users");

            var template = user_collection.Find<User>(user => true).ToList();
            foreach (var item in template)
            {
                var id = item._id;
            }
        }
    }
}
