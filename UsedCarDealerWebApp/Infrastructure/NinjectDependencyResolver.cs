using System;
using System.Collections.Generic;
using Ninject;
using System.Web.Mvc;
using UsedCarDealer.Domain.Concrete;
using UsedCarDealer.Domain.Abstract;
using UsedCarDealerWebApp.Infrastructure.Abstract;
using UsedCarDealerWebApp.Infrastructure.Concrete;

namespace UsedCarDealerWebApp.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<ICarRepository>().To<EfCarRepository>();
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }

}
