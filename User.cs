using System;
using System.Net;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(Musician), typeof(Contractor))]
    [RootEntity]
    public abstract class User : BaseEntity, ILocatable
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public PhoneNumber Phone { get; set; }

        public DateTime? StartDate { get; set; }

        public FileReference Avatar { get; set; }

        public Address Address { get; set; }
           
        public bool EmailConfirmed { get; set; }

        public PremiumLevel PremiumLevel { get; set; }

        public string About { get; set; }

        public long FileBytesOccupied { get; set; }
        public long FileBytesLimit { get; set; }

        public GeoJsonPoint<GeoJson3DGeographicCoordinates> Position { get { return TrackedPosition?.Entity; } }
        public TrackedEntity<GeoJsonPoint<GeoJson3DGeographicCoordinates>> TrackedPosition { get; set; }

        public TrackedEntity<IPAddress> Ip { get; set; }

        public string Kind { get { return GetType().Name; } }
    }
}