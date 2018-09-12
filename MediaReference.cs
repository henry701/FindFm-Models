using MongoDB.Bson;

namespace Models
{
    public class MediaReference : BaseEntity<ObjectId>
    {
        public virtual MediaMetadata MediaMetadata { get; set; }
    }
}