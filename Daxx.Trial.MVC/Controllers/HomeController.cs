// -------------------------------------------------------------------------------------------------------------
//  HomeController.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Web.Mvc;
using CodeContracts;
using Daxx.Trial.MVC.Models;
using Daxx.Trial.Abstractions.Interfaces;

namespace Daxx.Trial.MVC.Controllers
{
    /// <summary>
    /// Process information about trades.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// The trades trades repository
        /// </summary>
        private readonly ITradesRepository _tradesTradesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="tradesRepository">The trades repository.</param>
        public HomeController(ITradesRepository tradesRepository)
        {
            Requires.NotNull(tradesRepository, nameof(tradesRepository));
            _tradesTradesRepository = tradesRepository;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>Result of rendering of the home page according to the model.</returns>
        public ActionResult Index()
        {
            var model = _tradesTradesRepository.GetAll().Select(e => (TradeInfoViewModel)e).ToList();
            return View(model);
        }
    }
}