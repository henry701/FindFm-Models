using System;
using System.Net;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(Musician))]
    [BsonKnownTypes(typeof(Contractor))]
    [RootEntity]
    public abstract class User : BaseEntity
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public PhoneNumber Phone { get; set; }

        public DateTime StartDate { get; set; }

        public ImageReference Avatar { get; set; }

        public Address Address { get; set; }
           
        public bool EmailConfirmed { get; set; }

        public PremiumLevel PremiumLevel { get; set; }

        public TrackedEntity<GeoJsonPoint<GeoJson2DGeographicCoordinates>> Position { get; set; }
        public TrackedEntity<IPAddress> Ip { get; set; }

        public string Kind { get { return GetType().Name; } }
    }
}