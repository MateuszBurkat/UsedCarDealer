using System.Linq;
using System.Web.Mvc;
using UsedCarDealer.Domain.Abstract;
using UsedCarDealer.Domain.Entities;
using UsedCarDealerWebApp.Models;

namespace UsedCarDealerWebApp.Controllers
{
    public class CarController : Controller
    {
        // GET: Car

        private ICarRepository repository;

        public CarController(ICarRepository carRepository)
        {
            this.repository = carRepository;
        }
        public ViewResult List(string carBrand)
        {
            CarsListViewModel viewModel = new CarsListViewModel
            {
                Cars = repository.Cars
                .Where(c => carBrand == null || c.CarBrand == carBrand),
                CurrentCarBrand = carBrand
            };
            return View(viewModel);
        }
        public FileContentResult GetImage(int carID)
        {
            Car ca = repository.Cars.FirstOrDefault(c => c.CarID == carID);
            if (ca != null)
            {
                return File(ca.ImageData, ca.ImageMimeType);

            }
            else
            {
                return null;
            }
        }
    }
}