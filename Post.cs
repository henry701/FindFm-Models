using System.Collections.Generic;
using System.Net;
using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    [RootEntity]
    public class Post : BaseEntity, ILikeAware
    {
        public User Poster { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Position { get; set; }
        public IPAddress Ip { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public IList<FileReference> FileReferences { get; set; }

        public IList<Comment> Comments { get; set; }
        
        public ISet<ObjectId> Likes { get; set; }
    }
}
