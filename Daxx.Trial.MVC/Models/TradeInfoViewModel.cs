// -------------------------------------------------------------------------------------------------------------
//  TradeInfoViewModel.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

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
            Id = entity.Id;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

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
    }
}