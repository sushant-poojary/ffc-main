using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ffc_backend.Model.collection
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
