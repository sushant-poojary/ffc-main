using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;

namespace ffc_backend.Model.collection
{
    public class GameMeta
    {
        public int max_points { get; set; }
        public bool use_points { get; set; }
        public int points { get; set; }
        public string team_1 { get; set; }
        public string team_2 { get; set; }
        public List<Cricketer> players { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string captain { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string vice_captain { get; set; }
    }
}
