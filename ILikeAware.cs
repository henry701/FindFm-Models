using System.Collections.Generic;
using MongoDB.Bson;

namespace Models
{
    public interface ILikeAware
    {
        /// <summary>
        /// A <see cref="ISet{T}"/> of <see cref="ObjectId"/>s representing <see cref="User"/>s
        /// that "liked" this entity.
        /// </summary>
        ISet<ObjectId> Likes { get; set; }
    }
}