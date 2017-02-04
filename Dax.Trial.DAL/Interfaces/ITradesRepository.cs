// -------------------------------------------------------------------------------------------------------------
//  ITradesRepository.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using Daxx.Trial.DAL.Entities;

namespace Daxx.Trial.DAL.Interfaces
{
    /// <summary>
    /// Defines repository contract for ScheduledBackup entity.
    /// </summary>
    public interface ITradesRepository : IRepository<TradeInfoEntity>
    {
    }
}