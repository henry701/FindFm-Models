using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Instrument
    {
        public string Name { get; set; }
        public SkillLevel SkillLevel { get; set; }
    }
}