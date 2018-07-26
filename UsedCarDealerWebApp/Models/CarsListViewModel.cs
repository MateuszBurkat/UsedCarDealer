using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsedCarDealer.Domain.Entities;

namespace UsedCarDealerWebApp.Models
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentCarBrand { get; set; }

    }
}