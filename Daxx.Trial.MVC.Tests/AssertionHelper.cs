// -------------------------------------------------------------------------------------------------------------
//  AssertionHelper.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using Daxx.Trial.Abstractions.Entities;
using Daxx.Trial.Abstractions.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daxx.Trial.MVC.Tests
{
    public static class AssertionHelper
    {
        /// <summary>
        /// Asserts if the model equal to the entity (in terms of the tracking properties).
        /// </summary>
        /// <param name="sourceEntity">The trade information entity.</param>
        /// <param name="entity">The entity to compare with.</param>
        public static void AreEqualToEntity(this ITradeInfoEntity sourceEntity, TradeInfoEntity entity)
        {
            Assert.AreEqual(entity.Id, sourceEntity.Id);
            Assert.AreEqual(entity.Name, sourceEntity.Name);
            Assert.AreEqual(entity.Category, sourceEntity.Category);
            Assert.AreEqual(entity.City, sourceEntity.City);
            Assert.AreEqual(entity.CountryCode, sourceEntity.CountryCode);
            Assert.AreEqual(entity.Url, sourceEntity.Url);
        }
    }
}