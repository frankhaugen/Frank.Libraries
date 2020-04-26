using Frank.Extensions.MongoDb;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Frank.Extensions.Worker.Models
{
    public class Car : IMongoEntity
    {
        [BsonId]
        public ObjectId _Id { get; set; }

        public string Name { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Bought { get; set; }
    }
}
