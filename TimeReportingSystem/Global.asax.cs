using DAL.Models;
using DAL.Repository;
using DAL.Repository.Contracts;
using Ninject;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TimeReportingSystem.MapService;

namespace TimeReportingSystem
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IKernel kernel = new StandardKernel();
            IKernel repKernel = new StandardKernel();
            //----------------------------------------
            kernel.Bind<IMapper>().To<CommonMapper>();
            repKernel.Bind<IRepository<Project>>().To<JsonRepository<Project>>();
            //----------------------------------------
            DependencyResolver.SetResolver(new MapDependencyResolver(kernel));
            DependencyResolver.SetResolver(new RepositoryDependencyResolver(repKernel));

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }

    public class MapDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;
        public MapDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType,new IParameter[0]);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType, new IParameter[0]);
        }
    }

    public class RepositoryDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;
        public RepositoryDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType, new IParameter[0]);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType, new IParameter[0]);
        }
    }
}