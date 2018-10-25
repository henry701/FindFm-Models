using MongoDB.Bson;

namespace Models
{
    public class FileReference : BaseEntity<ObjectId>
    {
        public virtual FileInfo FileInfo { get; set; }
    }
}