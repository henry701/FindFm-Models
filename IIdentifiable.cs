using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    /// <summary>
    /// Base interface for all models that have IDs, so that they can be referred to dynamically.
    /// </summary>
    public interface IIdentifiable
    {
        [BsonId]
        ObjectId _id { get; }
    }
}