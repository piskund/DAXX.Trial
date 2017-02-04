// -------------------------------------------------------------------------------------------------------------
//  TradeInfoViewModelTests.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using Daxx.Trial.DAL.Entities;
using Daxx.Trial.MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

namespace Daxx.Trial.MVC.Tests.Models
{
    [TestClass]
    public class TradeInfoViewModelTests
    {
        [TestMethod]
        public void TradeInfoEntity_MapsOn_TradeInfoViewModel_ThroughCopyCtor()
        {
            // Arrange
            var tradeEntity = new Fixture().Freeze<TradeInfoEntity>();

            // Act
            var sut = new TradeInfoViewModel(tradeEntity);

            // Assert
            sut.AreEqualToEntity(tradeEntity);
        }

        [TestMethod]
        public void TradeInfoEntity_MapsOn_TradeInfoViewModel_ThroughCast()
        {
            // Arrange
            var tradeEntity = new Fixture().Freeze<TradeInfoEntity>();

            // Act
            var sut = (TradeInfoViewModel)tradeEntity;

            // Assert
            sut.AreEqualToEntity(tradeEntity);
        }
    }
}