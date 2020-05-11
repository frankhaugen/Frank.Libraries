using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frank.Extensions.MongoDb
{
    public class MongoEntity
    {
        [BsonId]
        public ObjectId _Id { get; set; }
    }
}