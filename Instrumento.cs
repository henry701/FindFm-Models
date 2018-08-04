using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Instrumento : IIdentifiable
    {
        [BsonId]
        public ObjectId _id { get; set; }
    }
}