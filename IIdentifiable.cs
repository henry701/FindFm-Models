using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    /// <summary>
    /// Base interface for all models that have IDs, so that they can be referred to dynamically.
    /// </summary>
    public interface IIdentifiable<TIdentifier>
    {
        [BsonId]
        TIdentifier _id { get; }
    }
}