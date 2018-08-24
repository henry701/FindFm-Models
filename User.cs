using System;
using System.Net;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    [BsonKnownTypes(typeof(Musician))] // TODO: Expand
    public abstract class User : BaseEntity<ObjectId>
    {
        public string Email { get; set; }
        public byte[] Password { get; set; }

        public ImageReference Avatar { get; set; }

        public string Name { get; set; }

        public bool IsConfirmed { get; set; }

        public PremiumLevel PremiumLevel { get; set; }

        public TrackedEntity<GeoJsonPoint<GeoJson2DGeographicCoordinates>> Position { get; set; }
        public TrackedEntity<IPAddress> Ip { get; set; }

        public string Kind { get { return this.GetType().Name; } }
    }
}