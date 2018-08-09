using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Instrument : IIdentifiable
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public SkillLevel SkillLevel { get; set; }
    }
}