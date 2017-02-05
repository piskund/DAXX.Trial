// -------------------------------------------------------------------------------------------------------------
//  IEntity.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

namespace Daxx.Trial.Abstractions.Interfaces
{
    /// <summary>
    /// Defines an idendifitable object (entity).
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; set; }
    }
}