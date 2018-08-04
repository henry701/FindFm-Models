using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public abstract class User : IIdentifiable
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public string Email { get; set; }
        public byte[] Senha { get; set; }
        public bool IsConfirmed { get; set; }
        public abstract Type Kind { get; }
    }
}