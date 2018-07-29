using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UsedCarDealer.Domain.Abstract;

namespace UsedCarDealerWebApp.Controllers
{
    public class NaviController : Controller
    {
        // GET: Navi

        private ICarRepository repository;
        public NaviController(ICarRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu()
        {

            IEnumerable<string> cb = repository.Cars
                .Select(x => x.CarBrand)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(cb);
        }
    }
}