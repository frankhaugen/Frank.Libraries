using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frank.Libraries.MongoDb
{
    public class MongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}