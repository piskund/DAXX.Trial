// -------------------------------------------------------------------------------------------------------------
//  JsonTradesListModel.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Daxx.Trial.Abstractions.Interfaces;

namespace Daxx.Trial.DAL.JsonBasedImpl.Models
{
    /// <summary>
    /// Represents model for serialize/deserialize collection of trades info in json format.
    /// </summary>
    /// <seealso cref="IEntity" />
    internal class JsonTradesListModel : IEntity
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>
        /// The offset.
        /// </value>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public List<JsonTradeInfoModel> Results { get; set; }
    }
}