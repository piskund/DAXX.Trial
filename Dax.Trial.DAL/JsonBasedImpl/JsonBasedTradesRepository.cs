// -------------------------------------------------------------------------------------------------------------
//  JsonBasedTradesRepository.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Daxx.Trial.DAL.Entities;
using Daxx.Trial.DAL.Interfaces;

namespace Daxx.Trial.DAL.JsonBasedImpl
{
    public class JsonBasedTradesRepository : ITradesRepository
    {
        public void Add(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        public long Count(Expression<Func<TradeInfoEntity, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TradeInfoEntity> GetAll(Expression<Func<TradeInfoEntity, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TradeInfoEntity> GetAll()
        {
            return new[] {new TradeInfoEntity {Id = 1}, new TradeInfoEntity {Id = 2}};
            //throw new NotImplementedException();
        }

        public IQueryable<TradeInfoEntity> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public TradeInfoEntity GetSingle(Expression<Func<TradeInfoEntity, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public void Update(TradeInfoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}