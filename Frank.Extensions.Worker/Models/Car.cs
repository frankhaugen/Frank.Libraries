using Frank.Extensions.MongoDb;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frank.Extensions.Worker.Models
{
    public class Car : IMongoEntity
    {
        [BsonId]
        public ObjectId _Id { get; set; }

        public string Name { get; set; }
        public BsonDateTime Bought { get; set; }
    }
}
