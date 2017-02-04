// -------------------------------------------------------------------------------------------------------------
//  TradeInfoEntity.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System;
using Daxx.Trial.DAL.Interfaces;

namespace Daxx.Trial.DAL.Entities
{
    /// <summary>
    /// Provides configuration info necessary to perform backup.
    /// </summary>
    [Serializable]
    public class TradeInfoEntity : IEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
    }
}