using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ffc_backend.Model.collection
{
    public class MetaContainer<T> where T : class
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string meta_type { get; set; }
        public T meta { get; set; }
    }
}
