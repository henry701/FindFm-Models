using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    public class Post : BaseEntity<ObjectId>, ILikeAware
    {
        public User Poster { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Position { get; set; }
        public IPAddress Ip { get; set; }

        public string Text { get; set; }
        public MediaReference MediaReference { get; set; }
        public List<Comment> Comments { get; set; }

        public uint Likes { get; set; }
    }
}
