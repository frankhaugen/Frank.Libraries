using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frank.Libraries.MongoDb
{
    public interface IMongoEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
    }
}
