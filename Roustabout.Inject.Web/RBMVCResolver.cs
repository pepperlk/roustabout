using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Roustabout.Inject.Web
{

    public static class HTTPAppRegisterHelper
    {
        public static void UseRBMVC(this HttpApplication app)
        {
            ControllerBuilder.Current.SetControllerFactory(new RBControllerFactory());
        }
    }

    class RBControllerFactory : DefaultControllerFactory, IControllerFactory
    {

        [DebuggerNonUserCode]
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            
            if (controllerType == null)
            {
                throw new HttpException(404,
                                        String.Format(
                                            CultureInfo.CurrentCulture,
                                            "Not Found",
                                            requestContext.HttpContext.Request.Path));
            }
            if (!typeof(IController).IsAssignableFrom(controllerType))
            {
                throw new ArgumentException(
                    String.Format(
                        CultureInfo.CurrentCulture,
                        "Not Controller Based",
                        controllerType),
                    "controllerType");
            }

            var controller = RB.Get(controllerType) as IController;
           // controller.Execute(requestContext);


            return controller;
        }

        //public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        //{
        //    if (requestContext == null)
        //    {
        //        throw new ArgumentNullException("requestContext");
        //    }
        //    if (String.IsNullOrEmpty(controllerName))
        //    {
        //        throw new ArgumentException(MvcResources.Common_NullOrEmpty, "controllerName");
        //    }
        //    RequestContext = requestContext;
        //    Type controllerType = GetControllerType(controllerName);
        //    IController controller = GetControllerInstance(controllerType);
        //    return controller;
        //}

        //public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ReleaseController(IController controller)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
