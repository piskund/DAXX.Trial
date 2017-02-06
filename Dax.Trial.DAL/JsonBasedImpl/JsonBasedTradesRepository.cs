// -------------------------------------------------------------------------------------------------------------
//  JsonBasedTradesRepository.cs created by DEP on 2017/02/06
// -------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeContracts;
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
        private readonly string _pathToJson;
        private readonly List<TradeInfoEntity> _tradeInfoCache = new List<TradeInfoEntity>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBasedTradesRepository"/> class.
        /// </summary>
        /// <param name="appDataProvider">The application data provider.</param>
        public JsonBasedTradesRepository(IAppDataProvider appDataProvider)
        {
            Requires.NotNull(appDataProvider, nameof(appDataProvider));
            _pathToJson = Path.Combine(appDataProvider.GetAppDataPath(), JsonTradeFileName);
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
            var trades = GetTradesAsync().Result;
            return trades.Count;
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
            var trades = GetTradesAsync().Result;
            return trades;
        }

        /// <summary>
        /// Gets all asynchronously.
        /// </summary>
        /// <returns>All trade info entities.</returns>
        public async Task<IEnumerable<TradeInfoEntity>> GetAllAsync()
        {
            return await GetTradesAsync();
        }

        /// <summary>
        /// Provides the queryable access to repositorie's data.
        /// </summary>
        /// <returns>The queryable collection.</returns>
        public IQueryable<TradeInfoEntity> GetQueryable()
        {
            var trades = GetTradesAsync().Result;
            return trades.AsQueryable();
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

        /// <summary>
        /// ounts entities in the repository asynchronously.
        /// </summary>
        /// <returns>Number of trade records.</returns>
        public async Task<long> CountAsync()
        {
            var trades = await GetTradesAsync();
            return trades.Count;
        }

        /// <summary>
        /// Initialises the cache of trades asynchronously.
        /// </summary>
        /// <returns></returns>
        private async Task<List<TradeInfoEntity>> GetTradesAsync()
        {
            if (!_tradeInfoCache.Any())
            {
                var trades = await JsonTradesInfoReader.ReadTradesFromFileAsync(_pathToJson);
                _tradeInfoCache.AddRange(trades.Results.Select(r => new TradeInfoEntity(r)));
            }

            return _tradeInfoCache;
        }
    }
}