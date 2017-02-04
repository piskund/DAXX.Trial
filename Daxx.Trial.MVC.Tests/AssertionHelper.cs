// -------------------------------------------------------------------------------------------------------------
//  AssertionHelper.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using Daxx.Trial.DAL.Entities;
using Daxx.Trial.MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daxx.Trial.MVC.Tests
{
    public static class AssertionHelper
    {
        /// <summary>
        /// Asserts if the model equal to the entity (in terms of the tracking properties).
        /// </summary>
        /// <param name="tradeInfoViewModel">The trade information view model.</param>
        /// <param name="entity">The entity.</param>
        public static void AreEqualToEntity(this TradeInfoViewModel tradeInfoViewModel, TradeInfoEntity entity)
        {
            Assert.AreEqual(entity.Id, tradeInfoViewModel.Id);
            Assert.AreEqual(entity.Name, tradeInfoViewModel.Name);
            Assert.AreEqual(entity.Category, tradeInfoViewModel.Category);
            Assert.AreEqual(entity.City, tradeInfoViewModel.City);
            Assert.AreEqual(entity.CountryCode, tradeInfoViewModel.CountryCode);
            Assert.AreEqual(entity.Url, tradeInfoViewModel.Url);
        }
    }
}