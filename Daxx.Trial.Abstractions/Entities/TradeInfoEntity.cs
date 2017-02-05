// -------------------------------------------------------------------------------------------------------------
//  TradeInfoEntity.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System;
using Daxx.Trial.Abstractions.Interfaces;

namespace Daxx.Trial.Abstractions.Entities
{
    /// <summary>
    /// Provides configuration info necessary to perform backup.
    /// </summary>
    [Serializable]
    public class TradeInfoEntity : ITradeInfoEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeInfoEntity"/> class.
        /// </summary>
        public TradeInfoEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradeInfoEntity"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public TradeInfoEntity(ITradeInfoEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Category = entity.Category;
            City = entity.City;
            CountryCode = entity.CountryCode;
            Url = entity.Url;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }
    }
}