using System;

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

        public static TrackedEntity<TEntity> From(TEntity entity)
        {
            return new TrackedEntity<TEntity>(entity);
        }

        public static TrackedEntity<TEntity> From(TEntity entity, DateTime dateTime)
        {
            return new TrackedEntity<TEntity>(entity, dateTime);
        }
    }
}
