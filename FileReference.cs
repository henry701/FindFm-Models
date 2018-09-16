using MongoDB.Bson;

namespace Models
{
    public class FileReference : BaseEntity<ObjectId>
    {
        public virtual FileMetadata FileMetadata { get; set; }
    }
}