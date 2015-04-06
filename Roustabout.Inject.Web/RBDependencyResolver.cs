using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;
using System.Net.Http;
using System.Web.Http;

namespace Roustabout.Inject.Web
{
    public static class WebApiConfigHelper
    {
        public static void UseRB(this HttpConfiguration config)
        {
            config.DependencyResolver = new RBDependencyResolver();
        }
    }

    public class RBDependencyResolver : RBDependencyScope, IDependencyResolver
    {

        public RBDependencyResolver()
            : base()
        {

        }


    }


    public class RBDependencyScope : IDisposable, IDependencyScope, IHttpControllerActivator
    {

        public IDependencyScope BeginScope()
        {
            return new RBDependencyScope();
        }

        public object GetService(Type serviceType)
        {

            return RB.Get(serviceType);


            //return null;

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {


            //return RB.Get(serviceType);

            return new List<object>(){ RB.Get(serviceType) };

        }

        public void Dispose()
        {

        }


        public System.Web.Http.Controllers.IHttpController Create(System.Net.Http.HttpRequestMessage request, System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            
            var scope = request.GetDependencyScope();
            return scope.GetService(controllerType) as IHttpController;
        }
    }
}
