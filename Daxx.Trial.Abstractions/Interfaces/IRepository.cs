﻿// -------------------------------------------------------------------------------------------------------------
//  IRepository.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Daxx.Trial.Abstractions.Interfaces
{
    /// <summary>
    /// Repository contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Add entity to the repository
        /// </summary>
        /// <param name="entity">the entity to add</param>
        void Add(T entity);

        /// <summary>
        /// All item count
        /// </summary>
        /// <returns></returns>
        long Count();

        /// <summary>
        /// Mark entity to be deleted within the repository
        /// </summary>
        /// <param name="entity">The entity to delete</param>
        void Delete(T entity);

        /// <summary>
        /// Get all the element of this repository
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Query entities from the repository that match the linq expression selection criteria
        /// </summary>
        /// <returns>
        /// the loaded entity
        /// </returns>
        IQueryable<T> GetQueryable();

        /// <summary>
        /// Updates entity within the the repository
        /// </summary>
        /// <param name="entity">the entity to update</param>
        void Update(T entity);
    }
}