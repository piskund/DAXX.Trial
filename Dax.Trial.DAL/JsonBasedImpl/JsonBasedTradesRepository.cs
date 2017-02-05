// -------------------------------------------------------------------------------------------------------------
//  JsonBasedTradesRepository.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Daxx.Trial.DAL.Entities;
using Daxx.Trial.DAL.Interfaces;

namespace Daxx.Trial.DAL.JsonBasedImpl
{
    public class JsonBasedTradesRepository : ITradesRepository
    {
        private const string PathToTradesJsonFile = @"/app_data/trades_info.json";
        private readonly List<TradeInfoEntity> _tradeInfoEntities;

        public JsonBasedTradesRepository(IAppDataProvider appDataProvider)
        {
            var pathToJson = Path.Combine(appDataProvider.GetAppDataPath(), "trades_info.json");
            var trades = JsonTradesInfoReader.ReadTradesFromFile(pathToJson);

            _tradeInfoEntities = trades.Result.Select(r => new TradeInfoEntity(r)).ToList();
        }

        public void Add(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            return _tradeInfoEntities.Count;
        }

        public void Delete(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TradeInfoEntity> GetAll()
        {
            return _tradeInfoEntities;
        }

        public IQueryable<TradeInfoEntity> GetQueryable()
        {
            return _tradeInfoEntities.AsQueryable();
        }

        public void Update(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}