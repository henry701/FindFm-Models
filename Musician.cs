using System;
using System.Collections.Generic;
using System.Net;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    public class Musician : User
    {
        public DateTime Born { get; set; }
        public IList<Instrument> Instruments { get; set; }
    }
}
