using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Comment : BaseEntity<ObjectId>, ILikeAware
    {
        public User Commenter { get; set; }
        public string Text { get; set; }
        public uint Likes { get; set; }
    }
}