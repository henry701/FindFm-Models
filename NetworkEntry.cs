using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class NetworkEntry : IIdentifiable<ObjectId>
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public IPAddress IPAddress { get; set; }
        public DateTime DateTime { get; set; }
        public NetworkEntryKind Kind { get; set; }
    }
}
