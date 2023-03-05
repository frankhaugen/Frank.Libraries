using MongoDB.Bson;

namespace Frank.Libraries.MongoDb;

public static class ObjectIdExtensions
{
    public static ObjectId ToObjectId(this string source)
    {
        if (ObjectId.TryParse(source, out var objectId))
        {
            return objectId;
        }

        return ObjectId.Empty;
    }
}