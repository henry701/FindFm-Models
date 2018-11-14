using System.Collections.Generic;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    [RootEntity]
    public class Advertisement : BaseEntity
    {
        public Contractor Poster { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Position { get; set; }

        public IList<FileReference> FileReferences { get; set; }
    }
}
