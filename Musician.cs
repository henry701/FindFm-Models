using System;
using System.Collections.Generic;
using System.Net;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    public class Musician : User
    {
        public DateTime Born { get; set; }
        public string City { get; set; }
        public IDictionary<Skill, SkillLevel> InstrumentSkills { get; set; }
    }
}
