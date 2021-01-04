using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ffc_backend.Model.collection
{
    public class Cricketer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
}
