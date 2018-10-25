using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class FileInfo
    {
        public FileMetadata FileMetadata { get; set; }
        public long Size { get; set; }
    }
}
