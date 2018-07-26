using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedCarDealer.Domain.Entities;
using System.Data.Entity;

namespace UsedCarDealer.Domain.Concrete
{
    public class EfDbContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
