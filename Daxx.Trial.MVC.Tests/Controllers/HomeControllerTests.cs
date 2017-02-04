// -------------------------------------------------------------------------------------------------------------
//  HomeControllerTest.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System.Web.Mvc;
using Daxx.Trial.DAL.Interfaces;
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
            var controller = new HomeController(repositoryMock.Object);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            repositoryMock.Verify(r => r.GetAll(), Times.Once());
        }
    }
}