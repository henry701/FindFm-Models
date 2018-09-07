using System;
using System.Collections.Generic;
using System.Net;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    public class Musician : User
    {
        public ISet<KeyValuePair<Skill, SkillLevel>> InstrumentSkills { get; set; }
        public ISet<Work> Works { get; set; }
        public ISet<Song> Songs { get; set; }
    }
}
