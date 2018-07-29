using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsedCarDealer.Domain.Abstract;
using UsedCarDealer.Domain.Entities;

namespace UsedCarDealerWebApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private ICarRepository repository;

        public AdminController(ICarRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Cars);
        }

        public ViewResult Edit(int carId)
        {
            Car car = repository.Cars
                .FirstOrDefault(c => c.CarID == carId);
            return View(car);
        }

        [HttpPost]
        public ActionResult Edit(Car car, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    car.ImageMimeType = image.ContentType;
                    car.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(car.ImageData, 0, image.ContentLength);
                }
                repository.SaveCar(car);
                TempData["message"] = string.Format("Zapisano {0} ", car.CarBrand);
                return RedirectToAction("Index");
            }
            else
            {
                return View(car);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Car());
        }

        [HttpPost]
        public ActionResult Delete(int carID)
        {
            Car deletedCar = repository.DeleteCar(carID);
            if (deletedCar != null)
            {
                TempData["message"] = string.Format("Usunięto {0}", deletedCar.CarBrand);

            }
            return RedirectToAction("Index");
        }
    }
}