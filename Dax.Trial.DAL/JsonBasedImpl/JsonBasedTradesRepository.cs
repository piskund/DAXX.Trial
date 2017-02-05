// -------------------------------------------------------------------------------------------------------------
//  JsonBasedTradesRepository.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Daxx.Trial.Abstractions.Entities;
using Daxx.Trial.Abstractions.Interfaces;

namespace Daxx.Trial.DAL.JsonBasedImpl
{
    /// <summary>
    /// Implementation of the repository base on json file as data source.
    /// </summary>
    /// <seealso cref="Daxx.Trial.Abstractions.Interfaces.ITradesRepository" />
    public class JsonBasedTradesRepository : ITradesRepository
    {
        private const string JsonTradeFileName = "trades_info.json";
        private readonly List<TradeInfoEntity> _tradeInfoEntities;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBasedTradesRepository"/> class.
        /// </summary>
        /// <param name="appDataProvider">The application data provider.</param>
        public JsonBasedTradesRepository(IAppDataProvider appDataProvider)
        {
            var pathToJson = Path.Combine(appDataProvider.GetAppDataPath(), JsonTradeFileName);
            var trades = JsonTradesInfoReader.ReadTradesFromFile(pathToJson);

            _tradeInfoEntities = trades.Results.Select(r => new TradeInfoEntity(r)).ToList();
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"> Not implemented because this repository is readonly in terms of the current task.</exception>
        public void Add(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Counts entities in the repository.
        /// </summary>
        /// <returns>Number of trade records.</returns>
        public long Count()
        {
            return _tradeInfoEntities.Count;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"> Not implemented because this repository is readonly in terms of the current task.</exception>
        public void Delete(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>All trade info entities.</returns>
        public IEnumerable<TradeInfoEntity> GetAll()
        {
            return _tradeInfoEntities;
        }

        /// <summary>
        /// Provides the queryable access to repositorie's data.
        /// </summary>
        /// <returns>The queryable collection.</returns>
        public IQueryable<TradeInfoEntity> GetQueryable()
        {
            return _tradeInfoEntities.AsQueryable();
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"> Not implemented because this repository is readonly in terms of the current task.</exception>
        public void Update(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}