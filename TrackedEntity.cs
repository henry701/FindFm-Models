using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Models
{
    public class TrackedEntity<TEntity>
    {
        public DateTime ModifiedDate { get; private set; }

        private TEntity _entity;
        public TEntity Entity
        {
            get => _entity;
            set
            {
                _entity = value;
                ModifiedDate = DateTime.UtcNow;
            }
        }

        public TrackedEntity(TEntity entity) : this(entity, DateTime.UtcNow)
        {

        }

        public TrackedEntity(TEntity entity, DateTime dateTime)
        {
            _entity = entity;
            ModifiedDate = DateTime.UtcNow;
        }

        public static TrackedEntity<IPAddress> From (IPAddress ipAddress, DateTime creationDate)
        {
            return null;
        }

        public static TrackedEntity<GeoJsonPoint<GeoJson2DGeographicCoordinates>> From ( DateTime creationDate)
        {
            return null;
        }
    }
}
