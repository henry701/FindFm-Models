using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class MediaReference : BaseEntity<ObjectId>
    {
        public virtual MediaMetadata MediaMetadata { get; set; }
    }
}