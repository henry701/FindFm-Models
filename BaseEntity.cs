using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class BaseEntity<TIdentifier> : IIdentifiable<TIdentifier>, IActivationAware
    {
        [BsonId]
        public TIdentifier _id { get; set; }
        public DateTime? DeactivationDate { get; set; }
    }

    public class BaseEntity : BaseEntity<ObjectId>
    {
        // Default is ObjectId entity
    }
}