using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    /// <summary>
    /// Class for correlation referencing of a <see cref="Models.User"/>.
    /// </summary>
    [RootEntity]
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(DataReferenceToken<>))]
    public class ReferenceToken : BaseEntity<string>
    {
        /// <summary>
        /// The user ID for the user which the token references.
        /// </summary>
        public ObjectId UserId { get; set; }

        /// <summary>
        /// The type of operation this token references.
        /// </summary>
        public TokenType TokenType { get; set; }
    }
}