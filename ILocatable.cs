using MongoDB.Driver.GeoJsonObjectModel;

namespace Models
{
    public interface ILocatable
    {
        GeoJsonPoint<GeoJson3DGeographicCoordinates> Position { get; }
    }
}