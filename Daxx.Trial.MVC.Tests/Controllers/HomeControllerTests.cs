// -------------------------------------------------------------------------------------------------------------
//  HomeControllerTests.cs created by DEP on 2017/02/06
// -------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Daxx.Trial.Abstractions.Entities;
using Daxx.Trial.Abstractions.Interfaces;
using Daxx.Trial.MVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Daxx.Trial.MVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void HomeIndex_CallsGetAll_Once()
        {
            // Arrange
            var repositoryMock = new Mock<ITradesRepository>();
            repositoryMock.Setup(r => r.GetAllAsync())
                .Returns(Task.FromResult(new List<TradeInfoEntity>() as IEnumerable<TradeInfoEntity>));

            var controller = new HomeController(repositoryMock.Object);

            // Act
            var result = controller.IndexAsync().Result;

            // Assert
            Assert.IsNotNull(result);
            repositoryMock.Verify(r => r.GetAllAsync(), Times.Once());
        }
    }
}