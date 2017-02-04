// -------------------------------------------------------------------------------------------------------------
//  TradeInfoViewModel.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using CodeContracts;
using Daxx.Trial.DAL.Entities;

namespace Daxx.Trial.MVC.Models
{
    public class TradeInfoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeInfoViewModel"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public TradeInfoViewModel(TradeInfoEntity entity)
        {
            Requires.NotNull(entity, nameof(entity));

            MapEntityToModel(entity);
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
        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [DataType(DataType.Url)]
        public string Url { get; set; }

        /// <summary>
        /// Performs an explicit conversion from <see cref="TradeInfoEntity"/> to <see cref="TradeInfoViewModel"/>.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator TradeInfoViewModel(TradeInfoEntity entity)
        {
            return new TradeInfoViewModel(entity);
        }

        /// <summary>
        /// Maps the entity to the model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        private void MapEntityToModel(TradeInfoEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Category = entity.Category;
            City = entity.City;
            CountryCode = entity.CountryCode;
            Url = entity.Url;
        }
    }
}