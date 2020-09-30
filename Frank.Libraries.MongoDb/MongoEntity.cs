using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frank.Libraries.MongoDb
{
    public class MongoEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
