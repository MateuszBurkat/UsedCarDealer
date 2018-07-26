using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedCarDealer.Domain.Abstract;
using UsedCarDealer.Domain.Entities;

namespace UsedCarDealer.Domain.Concrete
{
    public class EfCarRepository : ICarRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<Car> Cars
        {
            get { return context.Cars; }
        }
        public void SaveCar(Car car)
        {

            if (car.CarID == 0)
            {
                context.Cars.Add(car);
            }
            else
            {
                Car dbEntry = context.Cars.Find(car.CarID);
                if (dbEntry != null)
                {
                   
                    dbEntry.CarBrand = car.CarBrand;
                    dbEntry.CarModel = car.CarModel;
                    dbEntry.FuelType = car.FuelType;
                    dbEntry.YearProduction = car.YearProduction;
                    dbEntry.TypeCar = car.TypeCar;
                    dbEntry.Milage = car.Milage;
                    dbEntry.Price = car.Price;
                    dbEntry.ImageData = car.ImageData;
                    dbEntry.ImageMimeType = car.ImageMimeType;

                }
            }
            context.SaveChanges();
        }

        public Car DeleteCar(int carID)
        {
            Car dbEntry = context.Cars.Find(carID);
            if (dbEntry != null)
            {
                context.Cars.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;

        }
    }
}