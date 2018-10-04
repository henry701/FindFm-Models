using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Models
{
    public class Comment : BaseEntity<ObjectId>, ILikeAware
    {
        public User Commenter { get; set; }
        public string Text { get; set; }
        public ISet<ObjectId> Likes { get; set; }
        public DateTime CreationDate { get; set; }
    }
}