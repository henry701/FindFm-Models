﻿using System;
using System.Net;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    [BsonKnownTypes(typeof(Musician))] // TODO: Expand
    public abstract class User : IIdentifiable
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public string Email { get; set; }
        public byte[] Password { get; set; }

        public string ImageReference { get; set; }

        public string Name { get; set; }

        public bool IsConfirmed { get; set; }

        public PremiumLevel PremiumLevel { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> LastPosition { get; set; }
        public IPAddress LastIp { get; set; }

        public string Kind { get { return this.GetType().Name; } }
    }
}