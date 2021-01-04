using ffc_backend.Model.collection;
using ffc_backend.Model.database;
using MongoDB.Driver;
using System;

namespace ffc_backend.FccDBApi
{
    public class DBConnectionService
    {
        private readonly IDBConnectionSettings mDBConnectionSettings;

        MongoClient mDBClient;
        private readonly IMongoDatabase mDatabase;
        private readonly IMongoCollection<MetaContainer<EventMeta>> mEventTemplateCollection;
        private readonly IMongoCollection<MetaContainer<GameMeta>> mGameTemplateCollection;
        //private readonly IMongoCollection<User> mUsersCollection;

        public DBConnectionService(IDBConnectionSettings connectionSettings)
        {
            mDBConnectionSettings = connectionSettings;
            mDBClient = new MongoClient(mDBConnectionSettings.connectionString);
            mDatabase = mDBClient.GetDatabase(mDBConnectionSettings.databaseName);

            //mDBClient.
            //var cluster_desc = database.Client.Cluster.Description;
            //var dbList = client.ListDatabases().ToList();

            //event_meta_templates = mDatabase.GetCollection<EventMeta>("data_templates");

            //User newUser = new User() { name = "vishal", password = "dwad", username = "nightmare" };
            //user_collection.InsertOne(newUser);

            //var template = event_meta_templates.Find<EventMeta>(user => true).FirstOrDefault();

            mEventTemplateCollection = mDatabase.GetCollection<MetaContainer<EventMeta>>("data_templates");
            mGameTemplateCollection = mDatabase.GetCollection<MetaContainer<GameMeta>>("data_templates");

            var Eventtemplate = mEventTemplateCollection.Find<MetaContainer<EventMeta>>(user => true).FirstOrDefault();
            var Gametemplate = mGameTemplateCollection.Find<MetaContainer<GameMeta>>(fame => true).FirstOrDefault();
        }

        internal void RegisterUser(string username, string password, string name)
        {
            throw new NotImplementedException();
        }
    }
}
